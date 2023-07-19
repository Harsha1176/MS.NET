using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Person1
    {
        public string Name { get; set; }
        public string City { get; set; }
        public void PrintData()
        {
            Console.WriteLine("Your name is " +Name);
            Console.WriteLine("Your City is " +City);
        }

    }
    class Student1 : Person1
    {
        public string Course { get; set; }

    }
}
