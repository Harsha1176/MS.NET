using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session10_delegate
{

    public delegate void DelTest(int x, int y);//delegate wih parameter
    public delegate void Display();//dalegate without parameter
    internal class Program
    {
        public static void Add(int a, int b)
        {

            Console.WriteLine("The sum is " + (a + b));
        }
        public static void Sub(int a, int b)
        {

            Console.WriteLine("The SUb is " + (a - b));
        }
        public static void Mul(int a, int b)
        {

            Console.WriteLine("The Mul is " + (a * b));
        }
        public static void Div(int a, int b)
        {

            Console.WriteLine("The Div is " + (a / b));
        }
        static void Main1(string[] args)
        {
            DelTest de = new DelTest(Add);//Single Cast Delegates
                                          // de(2, 3);
                                          //de = calculater.Sub;
                                          //de(2, 3);

            Calculater calculator = new Calculater();
            Display di = new Display(calculator.show);//delegate without parameter so ,we have to call show method so , we use invok 
            di.Invoke();


            de += Sub;//sub(2,3)
            de += Mul;
            de -= Div;//Multcast delegates
            de.Invoke(2, 3);
            Console.ReadKey();
        }
    }
    public class Calculater
    {
        public void show()
        {
            Console.WriteLine("Hello");
        }
        public void Add(int a, int b)
        {

            Console.WriteLine("The sum is " + (a + b));
        }
        public void Sub(int a, int b)
        {

            Console.WriteLine("The SUb is " + (a - b));
        }
        public void Mul(int a, int b)
        {

            Console.WriteLine("The Mul is " + (a * b));
        }
        public void Div(int a, int b)
        {

            Console.WriteLine("The Div is " + (a / b));
        }
    }
}