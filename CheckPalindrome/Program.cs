using System;

class Program
{
    static bool IsPalindrome(string str)
    {
        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }

    static void Main()
    {
        string input = "racecar";
        bool isPalindrome = IsPalindrome(input);

        Console.WriteLine(isPalindrome); // Output: True
        Console.ReadKey();
    }
}
