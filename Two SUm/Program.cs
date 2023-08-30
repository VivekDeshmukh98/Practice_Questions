using System;
using System.Collections.Generic;

namespace Two_SUm
{
    public static int[] SumTwo(int[] nums, int target)
    {
        Dictionary<int, int> numToIndex = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (numToIndex.ContainsKey(complement))
            {
                return new int[] { numToIndex[complement], i };
            }

            numToIndex[nums[i]] = i;
        }

        throw new ArgumentException("No two numbers add up to the target sum.");
    }
    class Program
    {

        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 18;

            int[] result = TwoSumm(nums, target);
            Console.WriteLine($"Indices of two numbers: {result[0]}, {result[1]}");
        }
    }
}
