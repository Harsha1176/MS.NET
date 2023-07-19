using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.Models;

namespace WebApplication2.Controllers
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
            MyDBContext myDBContext = new MyDBContext();
            myDBContext.Courses.Add(new Course { Name = "BCA" });
            myDBContext.SaveChanges();
            return View();
        }

        public IActionResult Privacy()
        {
            MyDBContext myDBContext = new MyDBContext();
            var recrd = myDBContext.Courses.Where(x => x.Id == 1).FirstOrDefault();
            myDBContext.Courses.Remove(recrd);
            myDBContext.SaveChanges();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}