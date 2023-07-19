using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoDay_2
{
    internal class Class1
    {

        public string Studentname;
        public string MobileNo;
        public int Age;
        public string Course;
        public double Fees;
        private int RollNo;



      public int RollPrint
        {
          get { return RollNo; }
            set { 
                
                if(value > 0)
                RollNo = value; }
        }
        public void TakeInput()
        {
            Console.WriteLine("Enter Your Name,Mobile,course,age,fees,rollno");
            Studentname = Console.ReadLine();
            MobileNo = Console.ReadLine();
             Course = Console.ReadLine();
            Age = Convert.ToInt32(Console.ReadLine());
            Fees = Convert.ToDouble(Console.ReadLine());
            RollPrint= Convert.ToInt32(Console.ReadLine());

        }

        public void PrintData()
        {
            Console.WriteLine(Studentname);
            Console.WriteLine(MobileNo);
            Console.WriteLine(Course);
            Console.WriteLine(Age);
            Console.WriteLine(Fees);
            Console.WriteLine(RollNo);
            Console.ReadKey();
        }


    }
}
