using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session12_Day6
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            var student = new
            {
                studentName = "Ram",
                Age = 30,
                City = "Delhi",
                Country = "INDIA"
            };
            Console.WriteLine(student.studentName);
            Console.WriteLine(student.City);
            Console.WriteLine(student.Country);
            Console.WriteLine(student.Age);
            Console.ReadKey();  



        }
    }
}
