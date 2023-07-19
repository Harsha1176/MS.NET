using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoading
{
    internal class Program
    {


    // static void ProcessData(string name)
    //    {
    //        Console.WriteLine(name);
           
    //    }

    //    static int ProcessData(int i)
    //    {
    //        return i * i;
    //    }

    //    static int ProcessData(int i,int j)
    //    {
    //        return i + j;
    //    }






        static void Main(string[] args)
        {

           // CalSal1 obj = new CalSal1();
           // obj.CalculateSalary("FT");
           // Console.WriteLine(obj.CalculateSalary("FT", 2000));


            Student1 student1 = new Student1("bsc");

            student1.PrintData();

            Console.ReadKey();
        }
    }
}

