using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class Program
    {

        static void Main(string[] args)
        {
            School studentDB = new School();
            studentDB.PrintStudent();
            Console.ReadKey();
        }
    }

    public class School : IStudent, ISecurity, IEmployee
    {
        public void PrintStudent()//Normal  Implementation
        {
            Console.WriteLine("Thie is Student");
        }
        public void PrintSecurity()
        {
            Console.WriteLine("Thie is Security");
        }

        void IEmployee.PrintEmp()//Explicit Implementation
        {
            Console.WriteLine("Thie is Employee");
        }
    }
    public class Test
    {

    }

    interface IStudent
    {
        void PrintStudent();

    }
    interface ISecurity
    {
        void PrintSecurity();
    }
    interface IEmployee
    {
        void PrintEmp();
    }
    interface ICEmployee : IEmployee
    {
        void CPrintEmp();
    }
}