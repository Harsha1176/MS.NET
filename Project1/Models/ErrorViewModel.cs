using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Project1.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }


    public class EmployeeViewModel
    {
        public int EmpId { get; set; }
        public string EmployeeName { get; set; }
        public string FatherName { get; set; }
        public string MobileNo { get; set; }
    }

    public class StudentViewModel
    {
        public int StudentId { get; set; }
        public string Studentname { get; set; }
        public string Course { get; set; }
        public string MobileNo { get; set; }
        public string City { get; set; }
    }

    public class UserDBModel
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string MobileNo { get; set; }
        public string Name { get; set; }
        public string UserType { get; set; }
    }

    public class SignUpViewModel
    {
        //[Display(Name = "Enter User ID")]
        //[Required(ErrorMessage = "Enter email Id")]
        //[MaxLength(2)]
        public string Email { get; set; }
        public string Password { get; set; }
        [Compare("Password")]
        public string RetypePassword { get; set; }

        [Display(Name = "Enter Mobile Number")]
        [Required(ErrorMessage = "Enter Mobile")]
        [MaxLength(10)]
        public string MobileNo { get; set; }
        public string Name { get; set; }
        public string UserType { get; set; }
    }

    public class LoginViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class ChangePasswordViewModel
    {
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string RetypePassword { get; set; }
    }



   
}

