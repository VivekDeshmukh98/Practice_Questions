using Joining_and_Combining1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joining_and_Combining1
{
    class Program
    {
        //oin two lists of objects based on a common property using LINQ.
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                 new Student { StudentID = 1, Name = "Alice" },
            new Student { StudentID = 2, Name = "Bob" },
            new Student { StudentID = 3, Name = "Charlie" }
            };

            List<Grade> grades = new List<Grade>
        {
            new Grade { StudentID = 1, Course = "Math", Score = 85 },
            new Grade { StudentID = 2, Course = "History", Score = 92 },
            new Grade { StudentID = 3, Course = "Math", Score = 78 }
        };

            var jopinedData = students.Join(grades, student => student.StudentID,
                grade => grade.StudentID, (student, grade) => new
                {
                    student.Name,
                    grade.Course,
                    grade.Score
                });

            foreach (var item in jopinedData)
            {
                Console.WriteLine($"Name:{item.Name},Course:{item.Course},Score: {item.Score}");
            }
            Console.ReadKey();
        }
    }
}
