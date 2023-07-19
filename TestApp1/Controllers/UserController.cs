using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TestApp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
  
    {
        public static List<UserViewModel> userList = new List<UserViewModel>();
        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<UserViewModel> Get()
        {
            /*AdmissionDbContext ob = new AdmissionDbContext();
            var userlist = ob.Users.Where(x => x.UserType != "ADMIN").ToList();
            */
            //return View(userlist);
            return userList.ToList();
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public UserViewModel Get(int id)
        {
            var employeeView = userList.Where(x => x.Id == id).FirstOrDefault();
            return employeeView;
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post(UserViewModel viewModel)
        {
            userList.Add(viewModel);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

    
