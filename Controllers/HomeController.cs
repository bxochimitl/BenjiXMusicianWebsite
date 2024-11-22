using System.Diagnostics;
using BenjiXMusician_Website.Models;
using Microsoft.AspNetCore.Mvc;

namespace BenjiXMusician_Website.Controllers
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

        public IActionResult About()
        {
            return View();
        }

        public IActionResult LiveShows()
        {
            return View();
        }

        public IActionResult Discography()
        {
            return View();
        }

        public IActionResult Gallery()
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
