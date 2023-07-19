using Microsoft.AspNetCore.Mvc;
using Project1.Models;
using System.Diagnostics;

namespace Project1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult MyView()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [NonAction]
       public string GetMyName(string name)
        {
            return $"{name}";
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Index1()
        {
            return Redirect("/Home/MyView");
        }
           public IActionResult JsonResultDemo()
        {
            var data = new { Name = "Demo", Age = 30 };
            return Json(data);
        }
        public IActionResult FileResultDemo()
        {
            var path = "demo.png";
            return File(path, "image/png");
        }
        public IActionResult ContentResultDemo()
        {
            var conte = "Hello World";
            return Content(conte, "text/plain");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}