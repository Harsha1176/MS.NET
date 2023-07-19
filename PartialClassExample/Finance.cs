using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassExample
{
    public  partial class Finance
    {
        public  void SHowGST()
        {
            Console.WriteLine("Add this SHowGST method");
        }
        //public partial void PrintTestData()  // it will access from version 9.0
        //{
        //    Console.WriteLine("This is partial method implementation");
        //}


    }
}
