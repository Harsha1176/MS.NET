using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeSystem
{
    using System;
    using System.Collections.Generic;

    namespace StudentGradeSystem
    {
        public class Student1
        {
            public string name { get; set; }
            public int[] scores { get; set; }
            public char grade { get; set; }

            public void CalculateGrade()
            {
                int sum = 0;
                foreach (int score in scores)
                {
                    sum += score;
                }
                // double averageScore = sum / (double)scores.Length
                double averageScore = sum / 0.3;

                if (averageScore >= 90)
                    grade = 'A';
                else if (averageScore >= 80)
                    grade = 'B';
                else if (averageScore >= 70)
                    grade = 'C';
                else if (averageScore >= 60)
                    grade = 'D';
                else
                    grade = 'F';
            }
        }

        internal class Program
        {
            static void Main2(string[] args)
            {
                List<Student1> studentList = new List<Student1>()
            {
                new Student1 { name = "Ram", scores = new int[] { 90, 85, 92 } },
                new Student1 { name = "Shyam", scores = new int[] { 80, 75, 88 } },
                new Student1 { name = "Sita", scores = new int[] { 90, 95, 72 } }
            };

                foreach (Student1 student in studentList)
                {
                    student.CalculateGrade();
                    Console.WriteLine($"{student.name}: Average Score = {student.scores.Average()}, Grade = {student.grade}");
                }

                Console.ReadKey();
            }
        }
    }
}