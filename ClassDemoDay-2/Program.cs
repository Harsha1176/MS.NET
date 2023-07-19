using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoDay_2
{
    internal class Program
    {


        static void Main(string[] args)
        {



          Class1 c = new Class1();
             
           
            c.TakeInput();
            c.PrintData();
           
            c.Studentname = "Sita";
            Console.WriteLine(c.Studentname);
            c.Course = "java";
            Console.WriteLine(c.Course);
            c.MobileNo = "234545";
            Console.WriteLine(c.MobileNo);
            c.Course = "pg dac";
            Console.WriteLine(c.Course);
            c.Age = 30;
            Console.WriteLine(c.Age);
            c.Fees = 50000.00;
            Console.WriteLine(c.Fees);
           // c.RollPrint = -30;
          //  Console.WriteLine(c.RollPrint);
           
            
         
            Console.WriteLine("=====================");
            Console.ReadKey();
           
       
            

        }
    }
}
