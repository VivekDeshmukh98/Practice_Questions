using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupingAnd_Aggregation
{
    class Program
    {
        //- Calculate the average salary of employees within each department using LINQ.
        static void Main(string[] args)
        {
            //Calculating Average Salary by Department:
            List<Employee> employees=new List<Employee>
            {
                 new Employee { Name = "Alice", Salary = 60000, Department = "HR" },
            new Employee { Name = "Bob", Salary = 75000, Department = "IT" },
            new Employee { Name = "Charlie", Salary = 90000, Department = "IT" },
            new Employee { Name = "David", Salary = 55000, Department = "Finance" },
            new Employee { Name = "Eva", Salary = 70000, Department = "HR" }
            };

            var avgSalaryByDepartment = employees.GroupBy(emp => emp.Department)
                .Select(group => new
                {
                    Department = group.Key,
                    AverageSalary = group.Average(emp => emp.Salary)
                });

            foreach (var item in avgSalaryByDepartment)
            {
                Console.WriteLine($"Department: {item.Department}, Average Salary: {item.AverageSalary:C}");
            }
            Console.ReadKey();
        }
    
        
    }

}
