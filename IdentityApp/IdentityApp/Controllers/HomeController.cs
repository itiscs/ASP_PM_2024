using IdentityApp.Data;
using IdentityApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IdentityApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _db;

        UserManager<AppUser> _userManager;

       

        public HomeController(ILogger<HomeController> logger,
            ApplicationDbContext db,
            UserManager<AppUser> userManager)
        {
            _logger = logger;
            _db = db;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            if (Request.Query.Keys.Contains("mytheme"))
            {
                var t = Request.Query["mytheme"].ToString();
                @ViewData["theme"] = t;
                Response.Cookies.Append("theme", t);
            }

            if (Request.Cookies.Keys.Contains("theme"))
            {
                var t = Request.Cookies["theme"]?.ToString();
                @ViewData["theme2"] = t;
            }

            if (Request.Query.Keys.Contains("role"))
            {
                var t = Request.Query["role"].ToString();
                @ViewData["role"] = t;
                HttpContext.Session.SetString("role", t);
            }

            if (HttpContext.Session.Keys.Contains("role"))
            {
                var t = HttpContext.Session.GetString("role");
                @ViewData["role2"] = t;
            }

            return View();
        }

        [Authorize]
        public IActionResult Privacy()
        {
            // return View(_userManager.Users);
            return View(_db.Users);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
