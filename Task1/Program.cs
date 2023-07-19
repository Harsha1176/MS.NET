using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task1
{
    internal class Program
    {
        static void Main1 string[] args)
        {
            Student student = new Student
            {
                Name = "Harsha",
                Email = "harshaborkhade24@gmail.com",
                AadharNo = "2424459475",
                Course = "dac"
               
              

                   
        };
            
            student.DisplayUserInfo();
            Console.ReadKey();


        }

        public abstract class User
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string AadharNo { get; set; }
            public abstract void DisplayUserInfo();
        }

        public class Student : User
        {
            public string Course { get; set; }
            public override void DisplayUserInfo()
            {

                Console.WriteLine($"Name:{Name}, Email:{Email}, AadharNo:{AadharNo},Course:{Course}");
             

            }
            public class Professors : User
            {
                public string Department { get; set; }
                public override void DisplayUserInfo()
                {
                    Console.WriteLine($"Name:{Name},Email:{Email},AadharNo:{AadharNo},Department:{Department}");
                }

            }

            public class Administrative : User
            {
                public string Role { get; set; }
                public override void DisplayUserInfo()
                {
                    Console.WriteLine($" Name : {Name} Email : {Email} AadharNo : {AadharNo} Role : {Role}");
                    Console.WriteLine(" Name : " + Name + " Email :" + Email + " AadharNo :" + AadharNo + " Role : " + Role);
                }
            }



        }
    }
}
