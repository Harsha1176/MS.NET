using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session7_Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Array Example 1D array

            //int[] salary = new int[5];//first way
            //int[] salary2 = new int[5] { 23, 45, 67, 89, 20 };//Second Way
            //int[] salary3 = new int[] { 23, 67, 89, 20 };//Third Way
            //int[] salary4 = { 10, 20, 30 };//Fourth Way

            //salary[0] = 10000;
            //salary[1] = 20000;
            //salary[2] = 30000;
            //salary[3] = 40000;
            //salary[4] = 50000;
            //for (int i = 0; i < salary.Length; i++)
            //{
            //    Console.WriteLine(salary[i]);

            //}

            //Console.WriteLine("=================");
            //Console.WriteLine(salary[2]);
            //Console.WriteLine("=================");
            //foreach (int i in salary2)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.ReadKey();
            //}

            //==========================================================================================================================================================

            //2D array 

            //string[,] timetable = new string[2, 4]
            //    {
            //         {"Monday","MATH","Physics","English" },
            //         {"Tuesday","Physics","MATH","History" },
            //    };

            //Console.WriteLine("---Time table -----");
            //Console.WriteLine("==========================================");
            //for (int row = 0; row < timetable.GetLength(0); row++)
            //{
            //    for (int col = 0; col < timetable.GetLength(1); col++)
            //    {
            //        Console.Write(timetable[row, col] + "\t" + "|"+"\t");

            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadKey();
             // }

            //==========================================================================================================================================================
            //Jaggde Array 
        //    int[][] jarray = new int[2][];

        //    jarray[0] = new int[5] { 1, 2, 3, 4, 5 };
        //    jarray[1] = new int[2] { 1, 2 };

        //    Console.WriteLine(jarray[0][0]);
        //    Console.WriteLine(jarray[0][1]);
        //    Console.WriteLine(jarray[0][2]);
        //    Console.WriteLine(jarray[0][3]);
        //    Console.WriteLine(jarray[0][4]);
        //    Console.WriteLine(jarray[1][0]);
        //    Console.WriteLine(jarray[1][1]);
        //    Console.ReadKey();
        //}
            //==========================================================================================================================================================
            //Array Of Class 


            //Student student = new Student();
            Student[] student = new Student[3];//Array of class
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine("Yor are entering student" + (i + 1));
                student[i] = new Student();
                Console.WriteLine("Enter Your Name");
                student[i].Name = Console.ReadLine();
                Console.WriteLine("Enter Your id");
                student[i].Id = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine("===============================");
                Console.WriteLine("id =" +  student[i].Id + "Your Name =" +  student[i].Name);
            }
            Console.ReadKey();
        }

    }





    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    
}
