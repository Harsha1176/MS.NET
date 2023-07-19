using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session12_Day6
{
    internal class Calculator_ExtensionExample
    {

        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(2, 3));
            Console.WriteLine(calculator.Sub(3, 2));
            Console.WriteLine(calculator.Mul(3, 2));
            Console.WriteLine(calculator.Div(2, 2));
            Console.ReadKey();
        }

    }
    public static class ExtendMyCalculator
    {
        public static int Mul(this Calculator ob,int x, int y)
        {
            return (x*y);    
        }

        public static int Div(this Calculator ob,int x, int y)
        {
            return (x/y);
        }

    }

    public sealed class Calculator
    {
        public int Add(int x , int y)
        {
            return x + y;   
        }
        public int Sub(int x , int y) 
        { 
            return x - y;
        }
    }
}

