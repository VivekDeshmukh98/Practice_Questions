using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class Program
    {
        static void GenerateFibonacci(int n)
        {
            long[] fibonacci = new long[n];
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for(int i = 2; i <n; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            Console.WriteLine("Fibonacci Sequence (iterative):");

            foreach (long item in fibonacci)
            {
                Console.WriteLine(item+ " ");
            }
        }
        static void Main(string[] args)
        {
            int n = 10;
            GenerateFibonacci(n);
            Console.ReadLine();
        }
    }
}
