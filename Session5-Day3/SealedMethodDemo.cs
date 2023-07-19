using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5_Day3
{
    public  class BaseClass
    {
        public  virtual void PrintMessage()
        {
            Console.WriteLine("This is Base Class");
        }
    }

    public class   DerivedClass : BaseClass
    {
        public sealed override void PrintMessage()
        {
            Console.WriteLine("This is DerivedClass");
        }
    }
    public class FurtherDerivedClass : DerivedClass
    {
        public override void PrintMessage()// cannot override inherited member 'DerivedClass.PrintMessage()'because it is sealed
        {
            Console.WriteLine("This is Further Derived Class");
        }
    }
}