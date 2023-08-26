using System;
using System.Linq;

namespace Palindrome
{
    class Program
    {
        public static bool IsPalindrome(string s)
        {
            //Convert the string to lowercase and remove non-alphanumeric characters
            string cleanedstring = new string(s.ToLower().ToCharArray().Where(C => Char.IsLetterOrDigit(C)).ToArray());

            int left = 0;
            int right = cleanedstring.Length - 1;
            while (left < right)
            {
                if (cleanedstring[left] != cleanedstring[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
        
        static void Main(string[] args)
        {
            string input = "A man, a plan, a canal: Panama";
            bool result = IsPalindrome(input);

            Console.WriteLine($"Is the input is Palindrome: {result}");
        }
    }
}
