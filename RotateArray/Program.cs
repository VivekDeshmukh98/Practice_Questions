using System;

namespace RotateArray
{
    class Program
    {
        static void RotateArray(int[] array, int positions)
        {
            int length = array.Length;
            int[] rotatedArray = new int[length];

            for(int i=0; i < length; i++)
            {
                int newPosition = (i + positions) % length;//2
                rotatedArray[newPosition] = array[i];

            }

            for(int i = 0; i < length; i++)
            {
                array[i] = rotatedArray[i];
            }


        }
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            int positions = 2;

            RotateArray(numbers, positions);

            foreach(int number in numbers)
            {
                Console.Write(number+ " ");
            }
        }
    }
}
