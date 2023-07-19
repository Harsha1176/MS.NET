using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public static List<EmployeeViewModel> userList = new List<EmployeeViewModel>();
        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<EmployeeViewModel> Get()
        {
            /*AdmissionDbContext ob = new AdmissionDbContext();
            var userlist = ob.Users.Where(x => x.UserType != "ADMIN").ToList();
            */
            //return View(userlist);
            return userList.ToList();
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public EmployeeViewModel Get(int id)
        {
            var employeeView = userList.Where(x => x.EmpId == id).FirstOrDefault();
            return employeeView;
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post(EmployeeViewModel viewModel)
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
