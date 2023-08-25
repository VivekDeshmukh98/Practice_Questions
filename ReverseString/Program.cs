using System;

namespace ReverseString
{
    class Program
    {
        public static void ReverseString(char[] s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                char temp = s[left];
                s[left] = s[right];
                s[right] = temp;

                left++;
                right--;
            }
        }
        static void Main(string[] args)
        {
            char[] s = { 'q', 's', 'h', 'c', 'a', 'h' };
            Console.WriteLine("Original String : " + new string(s));

            ReverseString(s);
            Console.WriteLine("Original String : " + new string(s));


        }
    }
}
