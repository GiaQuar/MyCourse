public class Startup
{
    public void ConfigureServices(IServiceCollection services)
{
    services.AddControllersWithViews(); // più moderno di AddMvc()
}

public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IHostApplicationLifetime lifetime)
{
        //if (env.IsDevelopment())
        if (env.IsEnvironment("Development"))
        {
            app.UseDeveloperExceptionPage();

            //Aggiorniamo un file per notificare al BrowserSync che deve aggiornare la pagina
            lifetime.ApplicationStarted.Register(() =>
            {
                string filePath = Path.Combine(env.ContentRootPath, "bin/reload.txt");
                File.WriteAllText(filePath, DateTime.Now.ToString());
            });
        }
        else
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }

    app.UseStaticFiles();
    app.UseRouting();

    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
    });
}
}