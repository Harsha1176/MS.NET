using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2._2
{
    internal class ParamDemo
    {
     public static void PrintStudentName(params string[] names)
        {
            if (names.Length == 0)
                Console.WriteLine("No Record");
            else
            {
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
            }
        }

    }
}
