using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Security.Claims;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/Account/Login");
        }
        // [Authorize(Roles = "Employee")]

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel viewModel)
        {
            EmpDbContext ob = new EmpDbContext();
            var user = ob.User.FirstOrDefault(x => x.EmailId == viewModel.Email && x.Password == viewModel.Password);
            if (user != null)
            {
                var claims = new List<Claim>() {
                        new Claim(ClaimTypes.NameIdentifier, Convert.ToString(user.Id)),
                        new Claim(ClaimTypes.Name, user.FirstName),
                        new Claim(ClaimTypes.Role, user.UserType),

                };
                //Initialize a new instance of the ClaimsIdentity with the claims and authentication scheme
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                //Initialize a new instance of the ClaimsPrincipal with ClaimsIdentity    
                var principal = new ClaimsPrincipal(identity);
                //SignInAsync is a Extension method for Sign in a principal for the specified scheme.    
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties());
                return Redirect("/Account/Index");
            }
            else
            {
                ViewData["MSG"] = "Invalid usre Name or password";
                return View(viewModel);
            }


            
        }


        public IActionResult Dashbord()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(User user)
        {
            EmpDbContext ob = new EmpDbContext();


            bool IsEmail = ob.User.Any(x => x.EmailId == user.EmailId);

            if (IsEmail)
            {
                ViewData["MSG"] = "Email Exist";
                return View(user);
            }
            user.UserType = "Employee";
            ob.User.Add(user);
            int result = ob.SaveChanges();
            if (result > 0)
            {
                ViewData["MSG"] = "Account Created Please Login";
                ModelState.Clear();
                return View(null);
            }
            else
            {
                ViewData["MSG"] = "Network error";
                return View(user);
            }

        }
    }
}
    

