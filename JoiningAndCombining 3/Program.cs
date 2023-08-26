using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoiningAndCombining_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Combining Lists and Removing Duplicates with Union/Distinct:
            List<int> list1 = new List<int> { 1, 2, 3, 4, 5};
            List<int> list2 = new List<int> { 2, 7, 1, 9 ,5};


            var CombinedAndDistinct = list1.Union(list2);


            foreach (var item in CombinedAndDistinct)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
