namespace MyWebServer.Server.Routing
{
    using MyWebServer.Server.Http;
    using MyWebServer.Server.Responses;

    public interface IRoutingTable
    {
        IRoutingTable Map(string url, HttpMethod method, HttpResponse response);

        IRoutingTable MapGet(string url, HttpResponse response);
    }
}
