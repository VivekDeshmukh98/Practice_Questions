using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtering_And_Projection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Filtering Strings by Length
            List<string> stringList = new List<string>
            {
                "apple",
                "banana",
                "grape",
                "kiwi",
                "orange"
            };

            int minlength = 5;

            var filteredStrings = stringList.Where(str => str.Length >= minlength);

            foreach (var str in filteredStrings)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey();

        

        }
    }
}
