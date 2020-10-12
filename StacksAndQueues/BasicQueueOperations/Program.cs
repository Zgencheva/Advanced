using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int s = input[1];
            int x = input[2];

            int smallestNum = int.MaxValue;
            bool isTheXFound = false;
            bool isItEmpty = false;
            Queue<int> queue = new Queue<int>();
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < n; i++)
            {

                queue.Enqueue(nums[i]);
            }
            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }
            if (queue.Count == 0)
            {
                isItEmpty = true;
                
            }
            while (queue.Count > 0)
            {
                int currentNum = queue.Dequeue();
                if (currentNum == x)
                {
                    isTheXFound = true;
                }
                if (currentNum < smallestNum)
                {
                    smallestNum = currentNum;
                }
            }
            if (isTheXFound)
            {
                Console.WriteLine($"true");
            }
            else if (isItEmpty == true)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine($"{smallestNum}");
            }
        }
    }
}
