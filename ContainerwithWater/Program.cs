using System;

namespace ContainerwithWater
{
    
    class Program
    {

        public static int ContainerMaxAreaA(int[] height)
        {
            int maxArea = 0;
            int left = 0;
            int right = height.Length - 1;

            while (left < right)
            {
                int minHeight = Math.Min(height[left], height[right]);
                int currentArea = minHeight * (right - left);
                maxArea = Math.Max(maxArea, currentArea);

                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }

            }
            return maxArea;

        }
        static void Main(string[] args)
        {
            int[] heights = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int maxAreaAAA = ContainerMaxAreaA(heights);
            Console.WriteLine("Maximum Area: " +maxAreaAAA);
        }
    }
}





