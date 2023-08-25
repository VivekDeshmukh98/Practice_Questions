using System;

namespace MaxSubArray
{
    class Program
    {
        public static int MaxSubArray(int[] nums)
        {
            int maxSum = nums[0];
            int currentSum = nums[0];

            for(int i = 0; i < nums.Length; i++)
            {
                currentSum = Math.Max(nums[i], currentSum + nums[i]);
                maxSum = Math.Max(maxSum, currentSum);
            }
            return maxSum;
        }


        static void Main(string[] args)
        {
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int result = MaxSubArray(nums);
            Console.WriteLine("Maximum Subarray Sum: " + result);
        }
    }
}
