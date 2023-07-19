using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeSystem
{



    public class Student
    {
       public  string name { get; set; }
        public string [] subjects { get; set; }
        

        public int id { get; set; }


    }





    internal class Program
    {
        static void Main1(string[] args)
        {

  
          


            List<Student> studentlist = new List<Student>()
            { new Student { name = "Ram", subjects = new string[] { "math", "science", "english" }, id = 1 },
                new Student { name = "Shyam", subjects = new string[] { "math", "science", "english" }, id = 2 },
                new Student { name = "Sita", subjects = new string[] { "math", "science", "english" }, id = 3 }
            };
             foreach(Student st in studentlist) {
              
                Console.WriteLine($"{st.name}:{string.Join(",",st.subjects)}: {st.id}");
               
            }
            Console.ReadKey();

        }
    }
        }

