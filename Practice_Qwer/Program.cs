using System;

namespace Practice_Qwer
{
    class Program
    {

        static int SumOfElement(int[] array)
        {
            int sum = 0;
            foreach (int element in array)
            {
                sum += element;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50, 60 };
            int totalSum = SumOfElement(numbers);

            Console.WriteLine($"Sum of Elements: {totalSum}");

        }
    }
}
