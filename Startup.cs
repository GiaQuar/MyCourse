public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Aggiungi servizi qui
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {

        if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }
    else
    {
        // Middleware per la gestione degli errori in produzione
        app.UseExceptionHandler("/Error");
        app.UseHsts();
    }
        // Middleware per i file statici 
        app.UseStaticFiles();

        // Routing e altri middleware 
        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapGet("/", async context =>
            {
                await context.Response.WriteAsync("Hello from Startup.cs!");
            });
        });
    }
}