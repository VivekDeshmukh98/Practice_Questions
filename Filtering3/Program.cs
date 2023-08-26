using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtering3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 2, 3, 4, 5, 6, 8 };

            var squaredNumber = numbers.Select(num => num * num);

            foreach (var item in squaredNumber)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
