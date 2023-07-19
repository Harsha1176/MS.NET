using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Treading_Day7
{
   
            internal class Program
        {
            static void Main(string[] args)
            {
                ParameterizedThreadStart parathread = new ParameterizedThreadStart(PrintMe);//1st approch calling paameterise thread, using delegate we calling paarameterise function then pass in thread 
            Thread thread2 = new Thread(parathread);
            //
            ThreadStart thread = new ThreadStart(Test1);


                Thread thread1 = new Thread(thread);//Its is calling by default
                

                Thread thread3 = new Thread(PrintMe);
                thread1.Start();
                thread2.Start("HELLO");
                thread3.Start("ROCK");
                Console.ReadKey();
            }
            public static void PrintMe(object obj)
            {
                string Name = (string)obj;
                Console.WriteLine(Name);
            }
            public static void Test1()
            {
                for (int i = 0; i < 10; i++)
                {
                    if (i == 3)
                        Thread.Sleep(5000);
                    Console.WriteLine("This is Thread 1 :- " + i);
                }
            }
            public static void Test2()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("This is Thread 2 :- " + i);
                }
            }
            public static void Test3()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("This is Thread 3 :- " + i);
                }
            }
        }
    }
    