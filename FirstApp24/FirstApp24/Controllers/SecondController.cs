using Microsoft.AspNetCore.Mvc;

namespace FirstApp24.Controllers
{
    public class SecondController : Controller
    {
        public IActionResult Index(string id)
        {
            ViewData["Id"] = id;
            return View();
        }
    }
}
