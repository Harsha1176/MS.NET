using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition is:"+Cal.Add(1, 2));
            Console.WriteLine("Division is:"+Cal.Div(5, 25));
            Console.WriteLine("Multiplication is:"+Cal.Multi(4, 4));
            Console.WriteLine("subtraction is:"+Cal.Sub(6,3));
            Console.ReadKey();
        }

        public static class Cal
        {
            public static int Add(int x, int y)
            {
                return x + y;
            }
            public static int Div(int x, int y)
            {
                return x / y;
            }
            public static int Multi(int x,int y)
            {
                return x * y;
            }
            public static int Sub(int x,int y)
            {
                return x - y;
            }
        }
    }
}
