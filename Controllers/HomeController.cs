using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Services;
using System.Diagnostics;

namespace Portafolio.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositoryProyectos _proyectosRepository;
        private readonly ServiciosDelimitado serviciosDelimitado;
        private readonly ServiciosRepository serviciosRepository;
        private readonly ServiciosTransitorio serviciosTransitorio;

        public HomeController(ILogger<HomeController> logger, 
                              IRepositoryProyectos proyectosRepository,
                              ServiciosDelimitado serviciosDelimitado,
                              ServiciosRepository serviciosRepository,
                              ServiciosTransitorio serviciosTransitorio) {
            _logger = logger;
            this._proyectosRepository = proyectosRepository;
            this.serviciosDelimitado = serviciosDelimitado;
            this.serviciosRepository = serviciosRepository;
            this.serviciosTransitorio = serviciosTransitorio;
        }

        public IActionResult Index() {
            var proyectos = _proyectosRepository.ObtenerProyectos().Take(3).ToList();
            var guidModel = new GuidModel { 
                Delimitado = serviciosDelimitado.ObtenerGuid,
                Transitorio = serviciosTransitorio.ObtenerGuid,
                Unico = serviciosRepository.ObtenerGuid
            };
            var modelo = new HomeModel() { 
                Proyectos = proyectos,
                GuidExample = guidModel
            };

            return View(modelo);
        }

        public IActionResult Proyectos() {
            var proyectos = _proyectosRepository.ObtenerProyectos();

            return View(proyectos);
        }

        public IActionResult Contacto() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}