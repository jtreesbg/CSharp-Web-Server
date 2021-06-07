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
            .MapGet("/Cats", new HtmlResponse ("Hello from kotencata!"))
            .MapGet("/Dogs", new HtmlResponse("Hello from the dogos!")))
        .Start();
    }
}