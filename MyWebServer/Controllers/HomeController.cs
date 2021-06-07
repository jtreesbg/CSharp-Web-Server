using MyWebServer.Server;
using MyWebServer.Server.Http;
using MyWebServer.Server.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebServer.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(HttpRequest request)
            : base(request)
        {
        }

        public HttpResponse Index()
            => Text("Hello from Alex!");

        public HttpResponse LocalRedirect() => Redirect("/Cats");
        public HttpResponse ToSoftUni() => Redirect("https://softuni.bg");
    }
}
