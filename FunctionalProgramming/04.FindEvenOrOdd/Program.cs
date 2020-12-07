using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvenOrOdd
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
            for (int i = startNum; i <= endNum; i++)
            {
                //nums.Add(i);
                Func<int, bool> getDelegate = GetCondition(i, condition);
                if (getDelegate(i))
                {
                    Console.Write(i + " ");
                }
            }



        }

        static Func<int, bool> GetCondition(int num, string condition)
        {
            switch (condition)
            {
                case "even":
                    return num => num % 2 == 0;
                case "odd":
                    return num => num % 2 != 0;
                default:
                    return null;

            }

        }
    }
}
