using System;
using System.Linq;

namespace ReverseStringImp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string input = "Hello, World!";
            string reversed = new string(input.Reverse().ToArray());

            Console.WriteLine(reversed); // Output: !dlroW ,olleH

        }
    }