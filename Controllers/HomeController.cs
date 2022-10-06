using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;

namespace Portafolio.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
        }

        public IActionResult Index() {
            var proyectos = ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeModel() { Proyectos = proyectos };

            return View(modelo);
        }

        public IActionResult Privacy() {
            return View();
        }

        public List<ProyectModel> ObtenerProyectos() {
            return new List<ProyectModel>() { 
                new ProyectModel {
                    Titulo = "Contadores Cabañas", 
                    Descripcion = "Plataforma de presentación realizada en ASP.NET Core",
                    Link = "https://www.google.com",
                    ImgUrl = "/images/amazon.png"
                },
                 new ProyectModel {
                    Titulo = "Legal Advise",
                    Descripcion = "Plataforma de presentación realizada en Angular",
                    Link = "https://www.google.com",
                    ImgUrl = "/images/nyt.png"
                },
                new ProyectModel {
                    Titulo = "Mis contadores",
                    Descripcion = "Plataforma de presentación realizada en Angular",
                    Link = "https://www.google.com",
                    ImgUrl = "/images/reddit.png"
                },
                new ProyectModel {
                    Titulo = "Sistema de Paga",
                    Descripcion = "Plataforma de backend realizado en Nodejs",
                    Link = "https://www.google.com",
                    ImgUrl = "/images/steam.png"
                }
            };
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}