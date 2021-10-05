using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int s = input[1];
            int x = input[2];
            int minNum = int.MaxValue;
            bool isNumFound = false;
            Queue<int> queue = new Queue<int>();

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                queue.Enqueue(nums[i]);
            }
            if (queue.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                for (int i = 0; i < s; i++)
                {
                    queue.Dequeue();
                    if (queue.Count == 0)
                    {
                        break;
                    }
                }
                if (queue.Count == 0)
                {
                    Console.WriteLine("0");

                }
                else
                {
                    while (queue.Count > 0)
                    {
                        int currentNum = queue.Dequeue();
                        if (currentNum == x)
                        {
                            isNumFound = true;
                            Console.WriteLine($"true");
                            break;
                        }
                        else if (currentNum < minNum)
                        {
                            minNum = currentNum;
                        }

                    }
                    if (!isNumFound)
                    {
                        Console.WriteLine($"{minNum}");
                    }
                }


            }
        }
    }
}
