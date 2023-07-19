using Microsoft.AspNetCore.Mvc;

namespace Project1.Controllers
{
    public class StudentInfo : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
        public IActionResult Demo()
        {
            return View();
        }
    }
}
