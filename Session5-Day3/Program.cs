using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5_Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FurtherDerivedClass fd = new FurtherDerivedClass();
            fd.PrintMessage();
            BaseClass bs = new BaseClass();
          //BaseClass bs = new FurtherDerivedClass();
            bs.PrintMessage();
            bs.PrintMessage();  

            Console.ReadKey();
            


        }
    }
}
