using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using Project1.Models;
using System.Data;

using Project1;

namespace WebApp1.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            ProDBContext proDBContext = new ProDBContext();
            List<UserDBModel> signUpViewModels = new List<UserDBModel>();
            var userlist = proDBContext.Users.ToList();
            return View(userlist);


            //List<SignUpViewModel> signUpViewModels = new List<SignUpViewModel>();
            //string myConnectionString = "server=localhost;database=testpro1;uid=root;pwd=root;";
            //MySqlConnection sqlConnection = new MySqlConnection(myConnectionString);///
            //MySqlCommand sql = new MySqlCommand("SELECT * FROM Users", sqlConnection);
            //sqlConnection.Open();
            //MySqlDataReader sqlDataReader = sql.ExecuteReader();

            //DataTable dt = new DataTable();
            //dt.Load(sqlDataReader);
            //foreach (DataRow dr in dt.Rows)
            //{
            //    //, Password, MobileNo, Name, UserType
            //    signUpViewModels.Add(new SignUpViewModel
            //    {
            //        Name = dr["Name"].ToString(),
            //        Email = dr["Email"].ToString(),
            //        MobileNo = dr["MobileNo"].ToString(),
            //        Password = dr["Password"].ToString(),
            //        UserType = dr["UserType"].ToString()

            //    });
            //}
            //return View(signUpViewModels);

        }
    }
}