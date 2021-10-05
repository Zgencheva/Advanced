using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                int[] cmd = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int firstNum = cmd[0];
                if (firstNum == 1)
                {
                    stack.Push(cmd[1]);
                }
                else if (firstNum == 2)
                {
                    if (stack.Count != 0)
                    {
                        stack.Pop();
                    }
                }
                else if (firstNum == 3)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                    
                }
                else if (firstNum == 4)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }

            Console.WriteLine(String.Join(", ", stack));
        }
    }
}
