using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialCalculation
{
    class Program
    {
        static long CalculateFactorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Input must be non-negative");
            }

            if (n == 0 || n == 1)
            {
                return 1;
            }

            return n * CalculateFactorial(n - 1);
        }
        static void Main(string[] args)
        {

            int n = 5;
            long factorial = CalculateFactorial(n);
            Console.WriteLine($"Factorial of {n} is: {factorial}");
            Console.ReadLine();
        }
    }
}
