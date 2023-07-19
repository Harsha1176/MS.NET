using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoading
{
   
   

    internal class Student1
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
            set
            {

                if (value > 0)
                  RollNo = value;
            }
        }

        public Student1()
        {
            Console.WriteLine("Enter your Name,mobile,age ,Course,Roll No");
            Studentname= Console.ReadLine();
            MobileNo= Console.ReadLine();
            Age=Convert.ToInt32(Console.ReadLine());
            Course = "BSC";
         //  Course= Console.ReadLine();
            RollPrint= Convert.ToInt32(Console.ReadLine());

        }
        public Student1(string _Course)
        {
            Console.WriteLine("Enter your Name,mobile,age ,RollNo");
            Studentname = Console.ReadLine();
            MobileNo = Console.ReadLine();
            Age = Convert.ToInt32(Console.ReadLine());
            Course = _Course;
            RollPrint = Convert.ToInt32(Console.ReadLine());

        }
         
        
        public void PrintData()
        {
            Console.WriteLine("================");
            Console.WriteLine(Studentname);
            Console.WriteLine(MobileNo);
            Console.WriteLine(Age);
            Console.WriteLine(Course);
           // Console.WriteLine(RollNo);
           Console.WriteLine(RollPrint);
           
        }



    }
}
