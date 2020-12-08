using System;
using System.Linq;

namespace _08.CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //Func<int, bool> isEven = x => x % 2 == 0;
            //Func<int, bool> isOdd = x => x % 2 != 0;
            Array.Sort(nums, (x, y) =>
            {
                int sorter = 0;
                if (x % 2 == 0 && y % 2 != 0)
                {
                    sorter = -1;
                }
                else if (x % 2 != 0 && y % 2 == 0)
                {
                    sorter = 1;
                }
                else
                {
                    sorter = x - y;
                    //sorter = x.CompareTo(y);
                }
                return sorter;
            }
            );

            //nums = nums.OrderBy(isOdd).ThenBy(isEven).ToArray();
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
