﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_sessoion13
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            var emps = new List<Employee>()
            {
                new Employee(){ Name="Ravi",Age="30",Salary=100 },
                new Employee(){ Name="RAM",Age="30",Salary=200 },
                new Employee(){ Name="SITA",Age="30",Salary=3000 },
                new Employee(){ Name="SHYAM",Age="30",Salary=4000 },
                new Employee(){ Name="RAMESH",Age="30",Salary=5000 }
            };
            var query = emps.Where(x => x.Salary > 2000);
            // query = query.Where(x => x.Name.Contains("Ravi"));
            emps.Add(new Employee() { Name = "Ravi Kishan", Age = "30", Salary = 5500 });

            foreach (var e in query)
            {
                Console.WriteLine($"{e.Name}");
            }

            //Console.WriteLine(list);
            Console.ReadKey();

            //var number = new List<int> { 1, 2, 3, 4, 5 };
            //var query=number.Where(x => x %2 ==0 ).ToList();

            //number.Add(6);
            //foreach (var e in query)
            //{
            //        Console.WriteLine($"{e}");
            //}
            ////Console.WriteLine(list);
            //Console.ReadKey();


        }
    }
}
