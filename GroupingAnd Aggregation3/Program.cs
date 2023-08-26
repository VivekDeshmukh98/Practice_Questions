using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupingAnd_Aggregation3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Finding Department with the Highest Number of Employees:
            List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Alice", Salary = 60000, Department = "HR" },
            new Employee { Name = "Bob", Salary = 75000, Department = "IT" },
            new Employee { Name = "Charlie", Salary = 90000, Department = "IT" },
            new Employee { Name = "David", Salary = 55000, Department = "Finance" },
            new Employee { Name = "Eva", Salary = 70000, Department = "HR" }
        };

            var departmentWithHighestSalary = employees.GroupBy(emp => emp.Department).OrderByDescending(group => group.Count()).First();

            Console.WriteLine($"Department with the highest number of employees : {departmentWithHighestSalary.Key}");
            Console.ReadKey();
        }
        
    }
}
