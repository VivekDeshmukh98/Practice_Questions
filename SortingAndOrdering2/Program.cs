using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAndOrdering2
{
    class Program
    {
        //   - Order a list of objects by a specific property using LINQ.
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student{Name="Alice",Score= 85},
                new Student{Name="Bob",Score=92},
                new Student{Name="Charlie",Score=78},
                new Student{Name="David",Score=95}
            };

            //var sortedList = students.OrderBy(s => s.Score);
            var sortedList = students.OrderByDescending(s => s.Score);

            foreach (var item in sortedList)
            {
                Console.WriteLine($"{item.Name}: {item.Score}");
            }

            Console.ReadKey();

        }
    }
}
