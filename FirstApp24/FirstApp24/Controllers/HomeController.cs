using FirstApp24.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstApp24.Controllers
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
            ViewData["Name"] = "Admin";
            ViewBag.CurrentTime = DateTime.Now;

            ViewData["Week"] = new string[]{"monday","tuesday","sunday" };

            return View();
        }

        public IActionResult Privacy()
        {
            
            return View();
        }

        public IActionResult Contacts()
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
