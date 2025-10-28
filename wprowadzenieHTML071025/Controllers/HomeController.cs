using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using wprowadzenieHTML071025.Models;

namespace wprowadzenieHTML071025.Controllers
{
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Tabele()
        {
            return View();
        }

        public IActionResult Formularze()
        {
            return View();
        }

        public IActionResult Selektory()
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
