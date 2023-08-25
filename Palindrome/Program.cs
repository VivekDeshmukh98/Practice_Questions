using System;
using System.Linq;

namespace Palindrome
{
    class Program
    {
        public static bool IsPalindrome(string s)
        {
            //Convert the string to lowercase and remove non-alphanumeric characters
            string cleanedstring = new string(s.ToLower().ToCharArray().Where(C => Char.IsLetterOrDigit(c)).ToArray());

            int left = 0;


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
