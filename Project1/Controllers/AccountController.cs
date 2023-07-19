using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MySqlConnector;
using Project1.Models;
using System.Data;

namespace Project1.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
 
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            string myConnectionString = "server=localhost;database=testpro1;uid=root;pwd=root;";


            MySqlConnection sqlConnection = new MySqlConnection(myConnectionString);///
            MySqlCommand sql = new MySqlCommand("SELECT * FROM LOGIN", sqlConnection);
            sqlConnection.Open();
            MySqlDataReader sqlDataReader = sql.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            foreach (DataRow dr in dt.Rows)
            {
                string Uname = dr["Email"].ToString();
                string Password = dr["Password"].ToString();
            }


            if (loginViewModel.Email == "Test" & loginViewModel.Password == "Demo@123")
            {
                return Redirect("/Account/Dashboard");

            }
            else
            {
                return Redirect("Account/Index");
            }
        }

        public IActionResult Dashboard()
        {
            return View();
        }


        public IActionResult SignUp()
        {
            return View();
        }


        public bool CheckMobileNo(string mobileNo)
        {
            string myConnectionString = "server=localhost;database=testpro1;uid=root;pwd=root;";
            string sqlquery = $"SELECT COUNT(*) From users Where MobileNo='{mobileNo}'";
            MySqlConnection sqlConnection = new MySqlConnection(myConnectionString);///
            MySqlCommand command = new MySqlCommand(sqlquery, sqlConnection);
            sqlConnection.Open();
            command.CommandType = CommandType.Text;
            int Count = Convert.ToInt32(command.ExecuteScalar());
            sqlConnection.Close();
            if (Count > 0)
                return true;
            else
                return false;
        }
        public bool CheckMEmail(string email)
        {
            string myConnectionString = "server=localhost;database=testpro1;uid=root;pwd=root;";
            string sqlquery = $"SELECT COUNT(*) From users Where Email='{email}'";
            MySqlConnection sqlConnection = new MySqlConnection(myConnectionString);///
            MySqlCommand command = new MySqlCommand(sqlquery, sqlConnection);
            sqlConnection.Open();
            command.CommandType = CommandType.Text;
            int Count = Convert.ToInt32(command.ExecuteScalar());
            sqlConnection.Close();
            if (Count > 0)
                return true;
            else
                return false;
        }




        public IActionResult SignUp(SignUpViewModel signUpViewModel)
        {
            ProDBContext proDBContext = new ProDBContext();
            bool IsMobile = proDBContext.Users.Any(x => x.MobileNo == signUpViewModel.MobileNo);
            bool IsEmail = proDBContext.Users.Any(x => x.Email == signUpViewModel.Email);
            if (IsMobile)
            {
                ViewData["MSG"] = "Mobile Exist";
                return View(signUpViewModel);
            }
            if (IsEmail)
            {
                ViewData["MSG"] = "Email Exist";
                return View(signUpViewModel);
            }
            if (IsEmail == false && IsMobile == false)
            {
                var userDBModel = new UserDBModel();//Mapping
                userDBModel.Name = signUpViewModel.Name;
                userDBModel.Email = signUpViewModel.Email;
                userDBModel.Password = signUpViewModel.Password;
                userDBModel.MobileNo = signUpViewModel.MobileNo;
                userDBModel.UserType = "STUDENT";
                proDBContext.Users.Add(userDBModel);//addding data to db
                int result = proDBContext.SaveChanges();//saving data in db

                if (result > 0)
                {
                    ViewData["MSG"] = "Account Created Please Login";
                    ModelState.Clear();
                    return View(null);
                }
                else
                {
                    ViewData["MSG"] = "Network error";
                    return View(signUpViewModel);
                }
            }
            else
            {
                return View(signUpViewModel);
            }

        }



        //[HttpPost]
        //public IActionResult SignUp(SignUpViewModel signUpViewModel)
        //{


        //    bool IsMobile = CheckMobileNo(signUpViewModel.MobileNo);
        //    bool IsEmail = CheckMEmail(signUpViewModel.Email);
        //    if (IsMobile)
        //    {
        //        ViewData["MSG"] = "Mobile Exist";
        //        return View(signUpViewModel);
        //    }
        //    if (IsEmail)
        //    {
        //        ViewData["MSG"] = "Email Exist";
        //        return View(signUpViewModel);
        //    }
        //    if (IsEmail == false && IsMobile == false)
        //    {

        //        string myConnectionString = "server=localhost;database=testpro1;uid=root;pwd=root;";

        //        string sqlquery = "INSERT INTO users(Email,Password,MobileNo,Name,UserType)VALUES(@Email,@Password,@MobileNo,@Name,@UserType)";
        //        MySqlConnection sqlConnection = new MySqlConnection(myConnectionString);
        //        MySqlCommand command = new MySqlCommand(sqlquery, sqlConnection);
        //        sqlConnection.Open();
        //        command.CommandType = CommandType.Text;
        //        command.Parameters.Add("@Email", MySqlDbType.VarChar).Value = signUpViewModel.Email;
        //        command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = signUpViewModel.Password;
        //        command.Parameters.Add("@MobileNo", MySqlDbType.VarChar).Value = signUpViewModel.MobileNo;
        //        command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = signUpViewModel.Name;
        //        command.Parameters.Add("@UserType", MySqlDbType.VarChar).Value = "STUDENT";
        //        int result = command.ExecuteNonQuery();
        //        if (result > 0)
        //        {
        //            ViewData["MSG"] = "Account Created Please Login";
        //            ModelState.Clear();
        //            return View(null);
        //        }
        //        else
        //        {
        //            ViewData["MSG"] = "Network error";
        //            return View(signUpViewModel);
        //        }
        //    }
        //    else
        //    {
        //        return View(signUpViewModel);
        //    }

    //}
           


    
           


            //List<SignUpViewModel> userList = new List<SignUpViewModel>();
            //userList.Add(new SignUpViewModel { MobileNo = "23", Email = "a@yahoo.com" });
            //userList.Add(new SignUpViewModel { MobileNo = "34", Email = "b@yahoo.com" });
            //userList.Add(new SignUpViewModel { MobileNo = "56", Email = "c@yahoo.com" });
            //userList.Add(new SignUpViewModel { MobileNo = "78", Email = "d@yahoo.com" });

            ////
            //bool IsMobileExists = userList.Any(x => x.MobileNo == signUpViewModel.MobileNo);
            //if (IsMobileExists)
            //{
            //    ViewData["MSG"] = "Mobile Exists";
            //    return View(signUpViewModel);
            //}
            //bool IsEmailExists = userList.Any(x => x.Email == signUpViewModel.Email);
            //if (IsEmailExists)
            //{
            //    ViewData["MSG"] = "Email Exists";
            //    return View(signUpViewModel);
            //}
            //int IsMobileExists= userList.Where(x => x.MobileNo == signUpViewModel.MobileNo).ToList().Count();

            //return View();
       // }
        public IActionResult ChangePassword()
        {
            return View();
        }


        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordViewModel vw)
        {

            if (vw.NewPassword != vw.RetypePassword)
            {
                ViewData["MSG"] = "New Password Not match";
                return View(vw);
            }
            else
            {
                ViewData["MSG"] = "Password Changed";
                ModelState.Clear();
                return View(null);

            }
        }
    }
}
