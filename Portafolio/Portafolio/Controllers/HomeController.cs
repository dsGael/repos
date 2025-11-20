using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos _repositorioProyectos; 
        private readonly IRepositorioContacto _repositorioContacto;   

        public HomeController(ILogger<HomeController> logger,
            IRepositorioProyectos repositorioProyectos,
            IRepositorioContacto repositorioContacto)
        {
            _logger = logger;
            _repositorioProyectos = repositorioProyectos;
            _repositorioContacto = repositorioContacto;
        }

        public async Task<IActionResult> Index()
        {
            var proyectos = await _repositorioProyectos.ObtenerProyectos();

            var proyectosDestacados = proyectos.Take(3).ToList();

            var HomeIndexViewModel = new HomeIndexViewModel()
            {
                Proyectos = proyectosDestacados
            };
            
            return View(HomeIndexViewModel);
        }

        public async Task<IActionResult> Proyectos()
        {
            var proyectos = await _repositorioProyectos.ObtenerProyectos();
            return View(proyectos);
        }

        [HttpGet]
        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contacto(ContactoViewModel contactoViewModel)
        {
            if (ModelState.IsValid)
            {
                await _repositorioContacto.CrearContacto(contactoViewModel);
                
                return RedirectToAction("Gracias");
            }

            return View(contactoViewModel);
        }

        public IActionResult Gracias()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}