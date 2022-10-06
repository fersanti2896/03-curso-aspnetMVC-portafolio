using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Services;
using System.Diagnostics;

namespace Portafolio.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositoryProyectos _proyectosRepository;

        public HomeController(ILogger<HomeController> logger, IRepositoryProyectos proyectosRepository) {
            _logger = logger;
            this._proyectosRepository = proyectosRepository;
        }

        public IActionResult Index() {
            var proyectos = _proyectosRepository.ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeModel() { Proyectos = proyectos };

            return View(modelo);
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}