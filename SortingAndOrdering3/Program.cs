using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAndOrdering3
{
    class Program
    {
        // Write a LINQ query to find the top N highest scores from a list of student objects.
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                 new Student { Name = "Alice", Score = 85 },
            new Student { Name = "Bob", Score = 92 },
            new Student { Name = "Charlie", Score = 78 },
            new Student { Name = "David", Score = 95 },
            new Student { Name = "Eva", Score = 89 }
            };


            int topN = 3;

            var topScores = students.OrderByDescending(studentss => studentss.Score).Take(topN);

            foreach (var item in topScores)
            {
                Console.WriteLine($"{item.Name} : {item.Score}");
            }

            Console.ReadKey();
        }
    }
}
