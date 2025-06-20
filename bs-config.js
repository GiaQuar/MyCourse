// filepath: /Users/gq/Desktop/DotNetCorso/CorsoUdemyApp/bs-config.js
module.exports = {
    proxy: "localhost:5092",
    files: [
        "Views/**/*.cshtml",
        "wwwroot/**/*",
        "bin/reload.txt"
    ],
    watchEvents: ["change", "add", "unlink", "addDir", "unlinkDir"],
    watch: true,
    ignore: [],
    single: false,
    watchOptions: {
        ignoreInitial: true,
        ignored: '*.txt'
    },
    server: false,
    notify: true,
    open: true,
    reloadDelay: 50,
    reloadDebounce: 250,
    reloadThrottle: 0,
    plugins: [],
    injectChanges: true,
    startPath: null,
    minify: true,
    host: null,
    codeSync: true,
    timestamps: true,
    scriptPath: undefined,
    socket: {
        path: "/browser-sync/socket.io",
        clientPath: "/browser-sync",
        namespace: "/browser-sync"
    }
}