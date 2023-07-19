using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session6_Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            int add;
            //            int multi;
            //            int div;
            //            int sub;
            //            Sum(1, 2, out add, out multi, out div, out sub);
            //            Console.WriteLine(add);
            //            Console.WriteLine(multi);
            //            Console.WriteLine(div);
            //            Console.WriteLine(sub);
            //            Console.WriteLine(div);




            //            int add1 =0;
            //            int multi1=0;
            //            int div1 = 0;
            //            int sub1 = 0;
            //            Sum1(2, 2, ref add1, ref multi1, ref div1, ref sub1);
            //          Console.WriteLine(add1);
            //            Console.WriteLine(multi1);
            //            Console.WriteLine(div1);    



            //            Console.ReadKey();
            //        }
            //        //public static int Sum(int x, int y)
            //        //{
            //        //    return x + y;
            //        //}
            //        public static void Sum1(int x, int y, ref int add1, ref int multi1, ref int div1, ref int sub1)
            //        {
            //            add1 = x + y;
            //            multi1 = x * y;
            //            div1 = x / y;
            //            sub1 = x - y;
            //        }
            //        public static void Sum(int x, int y, out int add, out int mult, out int dv, out int sub)
            //        {
            //            add = x + y;
            //            mult = x * y;
            //            dv = x / y;
            //            sub = x - y;
            //        }
            //    }
            //}

            int? add = null;
            if (add.HasValue)
            {
                int value = add.Value;
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("Null Value");
                Console.ReadKey();
            }
        }
    }
}