using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Security.Claims;

namespace AdmissionApp.Controllers
{
    [Authorize(Roles = "Operator")]
    public class OperatorController : Controller
    {
        public IActionResult Index()
        {
            AdmissionDbContext ob = new AdmissionDbContext();
            var userlist = ob.Users.Where(x => x.UserType == "STUDENT").ToList();
            return View(userlist);
        }
        public IActionResult Edit(int Id)
        {
            AdmissionDbContext ob = new AdmissionDbContext();
            var dbuserdetails = ob.Users.FirstOrDefault(x => x.Id == Id);
            return View(dbuserdetails);
        }
        [HttpPost]
        public IActionResult Edit(Users viewModeldetails)
        {
            AdmissionDbContext ob = new AdmissionDbContext();
            var dbuserdetails = ob.Users.FirstOrDefault(x => x.Id == viewModeldetails.Id);

            if (dbuserdetails != null)
            {
                dbuserdetails.Name = viewModeldetails.Name;
                dbuserdetails.FatherName = viewModeldetails.FatherName;
                dbuserdetails.CourseName = viewModeldetails.CourseName;
                dbuserdetails.MotherName = viewModeldetails.MotherName;
                dbuserdetails.Address = viewModeldetails.Address;
                dbuserdetails.City = viewModeldetails.City;
                dbuserdetails.Pincode = viewModeldetails.Pincode;
                dbuserdetails.State = viewModeldetails.State;
                dbuserdetails.AdmissionStatus = "FILLED";
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
            AdmissionDbContext ob = new AdmissionDbContext();
            var dbuserdetails = ob.Users.FirstOrDefault(x => x.Id == Id);
            return View(dbuserdetails);
        }


    }
}
