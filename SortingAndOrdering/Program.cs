using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAndOrdering
{
    class Program
    {
        //Sort a list of strings in ascending order using LINQ.
        static void Main(string[] args)
        {
            List<string> stringList = new List<string>
            {
                "apple",
                "banana",
                "grape",
                "kiwi",
                "orange"
            };

            var sortedStrings = stringList.OrderBy(str => str);

            foreach (var item in sortedStrings)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
