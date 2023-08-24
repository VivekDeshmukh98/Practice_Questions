using System;

namespace RemoveDuplicate
{
    class Program
    {
        static int RemoveDuplicates(int[] array)
        {
            if (array.Length == 0)
                return 0;

            int newSize = 1;

            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] != array[newSize - 1])
                {
                    array[newSize] = array[i];
                    newSize++;
                }
            }
            return newSize;

        }
        static void Main(string[] args)
        {
            int[] sortedArray = { 10, 20, 30, 30, 40, 50, 60, 70 };
            int newLength = RemoveDuplicates(sortedArray);

            Console.WriteLine("Modified Array: ");

            for (int i = 0; i < newLength; i++)
            {
                Console.Write(sortedArray[i] + " ");
            }
        }
    }
}
