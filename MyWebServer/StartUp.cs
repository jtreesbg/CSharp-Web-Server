namespace MyWebServer
{
    using System.Threading.Tasks;
    using MyWebServer.Controllers;
    using MyWebServer.Server;
    using MyWebServer.Server.Controllers;

    public class Startup
    {
        public static async Task Main()
        => await new HttpServer(routes => routes
            .MapGet<HomeController>("/", c => c.Index())
            .MapGet<HomeController>("/Softuni", c => c.ToSoftUni())
            .MapGet<HomeController>("/ToCats", c => c.LocalRedirect())
            .MapGet<AnimalsController>("/Cats", c => c.Cats())
            .MapGet<AnimalsController>("/Dogs", c => c.Dogs()))
        .Start();
    }
}