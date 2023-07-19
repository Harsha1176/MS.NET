using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace EmployeeManagementSystem.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            EmpDbContext ob = new EmpDbContext();
            var userlist = ob.User.Where(x => x.UserType != "ADIMN").ToList();
            return View(userlist);
        }
        public IActionResult Edit(int Id)
        {
            EmpDbContext ob = new EmpDbContext();
            var dbuserdetails = ob.User.FirstOrDefault(x => x.Id == Id);
            return View(dbuserdetails);
        }
        [HttpPost]
        public IActionResult Edit(User viewModeldetails)
        {
            EmpDbContext ob = new EmpDbContext();
            var dbuserdetails = ob.User.FirstOrDefault(x => x.Id == viewModeldetails.Id);

            if (dbuserdetails != null)
            {
                dbuserdetails.FirstName = viewModeldetails.FirstName;
                dbuserdetails.LastName = viewModeldetails.LastName;
                dbuserdetails.EmailId = viewModeldetails.EmailId;
               
                ob.Update(dbuserdetails);
                ob.SaveChanges();
                return Redirect("/Admin/Index");
            }
            else
            {

                return View(dbuserdetails);
            }
        }
        public IActionResult Details(int Id)
        {
            EmpDbContext ob = new EmpDbContext();
            var dbuserdetails = ob.User.FirstOrDefault(x => x.Id == Id);
            return View(dbuserdetails);
        }
        public IActionResult Delete(int Id)
        {
            EmpDbContext ob = new EmpDbContext();
            var dbuserdetails = ob.User.FirstOrDefault(x => x.Id == Id);
            ob.User.Remove(dbuserdetails);
            ob.SaveChanges();
            return Redirect("/Admin/Index");
        }
    }
}