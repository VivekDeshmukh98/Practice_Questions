using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveZeroes
{
    class Program
    {
        public static int[] MoveZeroesToEnd(int[] nums)
        {
            //return nums.OrderBy(num => num == 0).ToArray();

            return nums.OrderByDescending(num => num == 0).ToArray();
        }

        static void Main(string[] args)
        {
            int[] nums = { 0, 3, 4, 0, 9, 01, 0 };

            int[] result = MoveZeroesToEnd(nums);

            Console.WriteLine(string.Join(", ",result));

            Console.ReadKey();
        }
    }
}
