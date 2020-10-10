using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> nums = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                nums.Push(input[i]);
            }
            while (true)
            {
                string command = Console.ReadLine();
                if (command.ToLower() == "end")
                {
                    break;
                }
                string[] commandArr = command.Split().ToArray();
                if (commandArr[0].ToLower() == "add")
                {
                    nums.Push(int.Parse(commandArr[1]));
                    nums.Push(int.Parse(commandArr[2]));
                }
                if (commandArr[0].ToLower() == "remove")
                {
                    int numsToRemove = int.Parse(commandArr[1]);
                    if (numsToRemove <= nums.Count)
                    {
                        for (int i = 0; i < numsToRemove; i++)
                        {
                            nums.Pop();
                        }
                    }
                }
            }
            int sum = 0;
            while (nums.Count > 0)
            {
                sum += nums.Pop();
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
