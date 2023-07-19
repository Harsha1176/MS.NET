using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day2._2
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Student student = new Student
            {
                StudentName = "harsha",
                Mobile = "235223",

            };
            Console.Write(student.StudentName);
            Console.Write("\n");
            Console.Write(student.Mobile);

            Circle circle = new Circle(20);
         //  circle._radius = 20;//read only use so we can not use again 
           // Console.Write(circle._radius);  

            //Class1.TestMethod(10, 20, true);//positional parameter
            // Class1.TestMethod(x: 20,z:true, y: 40);//named parameter
            // Console.ReadLine();

            //string[] name = { "gita", "RAM", "Shyam","sita"  };
            //ParamDemo.PrintStudentName(name);

           // LocalFunction.CalculateFee();
            Console.ReadKey();
        }
    }
}
