using System;

namespace RotateArray_2
{

    static void ReverseArray(int[] array)
    {
        int start = 0;
        int end = array.Length - 1;

        while (start < end)
        {
            //swap elements at start and end
            int temp = array[start];
            array[start] = array[end];
            array[end] = temp;

            //Move towards the center
            start++;
            end--;

        }

    }
    static void Main(string[] args)
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        Console.WriteLine("Original array");

        //foreach (int element in numbers)
        //{
        //    Console.WriteLine($"{element}");
        //}

        string arrayAsString = string.Join(", ", numbers);

        Console.WriteLine(arrayAsString);

        ReverseArray(numbers);

        Console.WriteLine("Reveresed Array");
        string ArrayAsString = string.Join(", ", numbers);
        Console.WriteLine(ArrayAsString);



    }
}
}
