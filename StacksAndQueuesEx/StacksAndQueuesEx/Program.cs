using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StacksAndQueuesEx
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
            Stack<int> stack = new Stack<int>(); 

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                stack.Push(nums[i]);
            }
            if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                for (int i = 0; i < s; i++)
                {
                    stack.Pop();
                    if (stack.Count == 0)
                    {
                        break;
                    }
                }
                if (stack.Count == 0)
                {
                    Console.WriteLine("0");
                    
                }
                else
                {
                    while (stack.Count > 0)
                    {
                        int currentNum = stack.Pop();
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
