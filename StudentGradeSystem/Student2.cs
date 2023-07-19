using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeSystem
{
    internal class Student2
    { 
      
            static void Main(string[] args)
        {
            // Define a list to store student scores as tuples
            List<(string, int, int, int)> studentScores = new List<(string, int, int, int)>();

                // Get the number of students from the user
                Console.Write("Enter the number of students: ");
                int numStudents = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                // Get the scores for each student
                for (int i = 0; i < numStudents; i++)
                {
                    Console.WriteLine($"Enter the scores for student {i + 1}:");

                    Console.Write("Math score: ");
                    int mathScore = Convert.ToInt32(Console.ReadLine());

                    Console.Write("English score: ");
                    int englishScore = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Science score: ");
                    int scienceScore = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();

                // Add student scores as a tuple to the list
                studentScores.Add(("Student " + (i + 1), mathScore, englishScore, scienceScore));
                }

                // Calculate average score and determine grade for each student
                Console.WriteLine("Grades:");
                foreach (var student in studentScores)
                {
                    double averageScore = (student.Item2 + student.Item3 + student.Item4) / 3.0;

                // Determine grade based on average score
                string grade;
                if (averageScore >= 90)
                    grade = "A";
                else if (averageScore >= 80)
                    grade = "B";
                else if (averageScore >= 70)
                    grade = "C";
                else if (averageScore >= 60)
                    grade = "D";
                else
                    grade = "F";




                Console.WriteLine($"{student.Item1}: Average Score = {averageScore}, Grade = {grade}");
                Console.ReadKey();
                }
            }
        }
    }
