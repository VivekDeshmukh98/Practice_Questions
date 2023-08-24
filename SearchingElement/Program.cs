using System;

namespace SearchingElement
{
    class Program
    {
        static int SearchElement(int[] array, int target)
        {
            for(int i = 0; i< array.Length;i++)
            {
                if (array[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            int target = 30;

            int index = SearchElement(numbers, target);

            if (index != -1)
            {
                Console.WriteLine($"Element {target} found at index {index}");
            }
            else
            {
                Console.WriteLine($"Element {target} not found in the array");
            }
        }
    }
}
