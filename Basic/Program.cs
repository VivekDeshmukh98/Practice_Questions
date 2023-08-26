using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            //Retrieve Even numbers using LINQ

            var evenNumbers = numbers.Where(num => num % 2 == 0);

            //Find the sum of all elements
            int sum = numbers.Sum();

            //Retreive distint elements
            var distinctNumbers = numbers.Distinct();

            Console.WriteLine("Evene Numbers");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num + " ");

                //string numberAsString = string.Join(", " + num);
                //Console.WriteLine(numberAsString);
            }


            Console.WriteLine("\n Sum of All Elements: "+sum);

            Console.WriteLine("\n Distinct Numbers: ");
            foreach (var item in distinctNumbers)
            {
                Console.WriteLine(item+ " ");
            }

            Console.ReadLine();
        }
    }
}
