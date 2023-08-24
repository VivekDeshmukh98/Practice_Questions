using System;

namespace FindMINMAx
{
    class Program
    {

        static void FindMaxMin(int[] array,out int max, out int min)
        {
            max = int.MinValue;
            min = int.MaxValue;

            foreach (int  element in array)
            {
                if (element > max)
                    max = element;

                if (element < min)
                {
                    min = element;
                }
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50, 60 };
            int min, max;

            FindMaxMin(numbers, out max, out min);

            Console.WriteLine($"Maximum value: {max}");

            Console.WriteLine($"Mininum  value: {min}");
        }
    }
}
