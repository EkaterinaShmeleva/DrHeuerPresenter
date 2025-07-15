using System.Diagnostics;
using DrHeuerVorstellung.Models;
using Microsoft.AspNetCore.Mvc;

namespace DrHeuerVorstellung.Controllers
{
    [ResponseCache(Duration = 60)]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UeberUns()
        {
            return View("UeberUns");
        }

        public IActionResult Bildungsangebot()
        {
            return RedirectToAction("Index", "Kategorien");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
