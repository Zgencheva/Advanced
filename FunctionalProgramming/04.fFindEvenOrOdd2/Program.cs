using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace _04.fFindEvenOrOdd2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int startNum = input[0];
            int endNum = input[1];
            //List<int> nums = new List<int>();
            string condition = Console.ReadLine();
            Func<int, int, List<int>> listNums = (startNum, endNum) =>
            {
                List<int> nums = new List<int>();
                for (int i = startNum; i <= endNum; i++)
                {
                    nums.Add(i);
                }
                return nums;

            };
            List<int> nums = listNums(startNum, endNum);
            Predicate<int> EvenPredicate = x => x % 2 == 0;
            Predicate<int> OddPredicate = x => x % 2 != 0;
            if (condition == "even")
            {
                nums = myWhere(nums, EvenPredicate);
            }
            else if (condition == "odd")
            {
                nums = myWhere(nums, OddPredicate);
            }

            Console.WriteLine(string.Join(" ", nums));
        }

        static List<int> myWhere(List<int> list, Predicate<int> predicate)
        {
            List<int> myList = new List<int>();

            foreach (var item in list)
            {
                if (predicate(item))
                {
                    myList.Add(item);
                }
            }

            return myList;
        
        }
    }
}
