using System;
using System.Linq;

namespace CheckPalindromeLINQ
{
    class Program
    {
        static bool IsPalindrome(string str)
        {
            return str.SequenceEqual(str.Reverse());
        }
        static void Main(string[] args)
        {
            string input = "racecar";
            bool isPAlindromeeee = IsPalindrome(input);

            Console.WriteLine(isPAlindromeeee);
        }
    }
}
