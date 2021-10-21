using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace WarmWinter
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int[] hatsArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] scarfsArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> hats = new Stack<int>(hatsArray);
            Queue<int> scarfs = new Queue<int>(scarfsArray);
            List<int> sets = new List<int>();
            while (hats.Count > 0 && scarfs.Count > 0)
            {
                int currentHat = hats.Peek();
                int currentScarf = scarfs.Peek();
                if (currentHat > currentScarf)
                {
                    sets.Add(currentScarf + currentHat);
                    hats.Pop();
                    scarfs.Dequeue();
                }
                else if (currentHat < currentScarf)
                {
                    hats.Pop();
                }
                else if (currentScarf == currentHat)
                {
                    scarfs.Dequeue();
                    currentHat++;
                    hats.Pop();
                    hats.Push(currentHat);
                }
            }
            int mostExpSet = sets.OrderByDescending(x => x).FirstOrDefault();
            Console.WriteLine($"The most expensive set is: {mostExpSet}");
            Console.WriteLine(string.Join(" ", sets));
        }
    }
}
