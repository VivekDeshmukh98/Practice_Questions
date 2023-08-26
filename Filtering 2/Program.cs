using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtering_2
{
    class Program
    {
        //Write a LINQ query to retrieve the names of employees whose salary is above a certain threshold
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Name="Alice",Salary=60000},
                new Employee { Name="Bob",Salary=75000},
                new Employee { Name="Charlie",Salary=90000},
                new Employee { Name="David",Salary=55000}
            };

            double minimumSalaryThreshold = 70000;

            var highSalaryEmployees = employees.Where(C => C.Salary >= minimumSalaryThreshold);


            foreach (var item in highSalaryEmployees)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadKey();
        }
    }
}
