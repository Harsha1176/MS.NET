using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolFeesManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<(string, string, double)> studentDetails = new List<(string, string, double)>();


            while (true)
            {
                Console.WriteLine("Fees management system : ");
                Console.WriteLine("1. Enter the student details:");
                Console.WriteLine("2.Display all student information :");
                Console.WriteLine("3.Calculate total fees collected :");
                Console.WriteLine("4.Calculate average fees amount paid :");
                Console.WriteLine("5.Exit");
                Console.Write("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                 

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter student details :");
                        Console.WriteLine("Name:  ");
                        string name = Console.ReadLine();

                        Console.WriteLine("Grade : ");
                        string grade = Console.ReadLine();

                        Console.WriteLine("Fees Paid: ");
                        double feesPaid = Convert.ToDouble(Console.ReadLine());

                        studentDetails.Add((name,grade,feesPaid));
                        Console.WriteLine("Student details added successfully.");
                        Console.WriteLine();
                        break;

                    case 2:
                Console.WriteLine("Student Information:");
                foreach (var student in studentDetails)
                {
                    Console.WriteLine($"Name: {student.Item1}");
                    Console.WriteLine($"Grade: {student.Item2}");
                    Console.WriteLine($"Fees Paid: {student.Item3}");
                    Console.WriteLine();
                }
                break;

            case 3:
                double totalFees = 0;
                foreach (var student in studentDetails)
                {
                    totalFees += student.Item3;
                }
                Console.WriteLine($"Total fees collected: {totalFees}");
                Console.WriteLine();
                break;

            case 4:
                double averageFee = 0;
                if (studentDetails.Count > 0)
                {
                    double totalPaid = 0;
                    foreach (var student in studentDetails)
                    {
                        totalPaid += student.Item3;
                    }
                    averageFee = totalPaid / studentDetails.Count;
                }
                Console.WriteLine($"Average fee amount paid: {averageFee}");
                Console.WriteLine();
                break;

               case 5:
                Console.WriteLine("Exiting program...");
                return;

               default:
                Console.WriteLine("Invalid choice. Please try again.");
                Console.WriteLine();
                break;
            }
        }
    }

}
    }

