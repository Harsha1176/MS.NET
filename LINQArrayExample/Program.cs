using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQArrayExample
{
    internal class Program
    {
        static void Main(string[] args)


        {
            // Array without LINQ
            //int[] salary = { 100, 200, 3000, 4000, 5000, 90, 1567 };
            //int count = 0;
            //foreach (int i in salary)
            //{
            //    if (i > 3000)
            //        count++;
            //}
            //Array.Sort(salary);
            //foreach (int i in salary)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(count);
            //Console.ReadKey();
            //====================================================================================================
            var emps = new List<Employee>()
            {
                new Employee(){ Name="Ravi",Age="30",Salary=100 },
                new Employee(){ Name="RAM",Age="30",Salary=200 },
                new Employee(){ Name="SITA",Age="30",Salary=3000 },
                new Employee(){ Name="SHYAM",Age="30",Salary=4000 },
                new Employee(){ Name="RAMESH",Age="30",Salary=5000 }
            };
            foreach (Employee e in emps)
            {
                if (e.Salary > 3000)
                {
                    Console.WriteLine($"{e.Name}{e.Age}{e.Salary}");
                }
            }
            Console.ReadKey();



        }
    }
}
