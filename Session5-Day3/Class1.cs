using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5_Day3
{
    
    public class BaseClass1
    {
        public void PrintMessage()
        {
            Console.WriteLine("This is base class Message");
        }
    }

    public class DerivedClass1 : BaseClass1
    {
        public new void PrintMessage()
        {
            Console.WriteLine("This is Child class Message");
        }
    }
}