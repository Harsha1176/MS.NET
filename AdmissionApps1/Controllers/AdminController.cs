using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdmissionApps.Controllers
{

    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
       
        public IActionResult Index()
        {
            AdmissionDbContext ob = new AdmissionDbContext();
            var userlist=ob.Users.ToList();
            return View(userlist);
        }
    }
}
