namespace MyWebServer
{
    using System.Threading.Tasks;
    using MyWebServer.Server;
    using MyWebServer.Server.Responses;

    public class Startup
    {
        public static async Task Main()
        => await new HttpServer(routes => routes
            .MapGet("/", new TextResponse("Hello from Alex!"))
            .MapGet("/Cats", new TextResponse("Hello from kotencata!"))
            .MapGet("/Dogs", new TextResponse("Hello from the dogos!")))
            .Start();
    }
}