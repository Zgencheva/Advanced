using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] caps = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] bottles = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> capsCapacity = new Queue<int>(caps);
            Stack<int> bottlesCapacity = new Stack<int>(bottles);
            int wastedWater = 0;
            bool isTheCapFull = true;
            int currentCap = 0;
            while (bottlesCapacity.Count > 0)
            {
                int currentBottle = bottlesCapacity.Pop();
                if (isTheCapFull)
                {
                    currentCap = capsCapacity.Peek();
                }
                
                if (currentBottle >= currentCap)
                {
                    capsCapacity.Dequeue();
                    isTheCapFull = true;
                    wastedWater += currentBottle - currentCap;
                }
                else
                {
                    currentCap -= currentBottle;
                    isTheCapFull = false;

                }
                if (capsCapacity.Count == 0)
                {
                    break;
                }
            }
            if (bottlesCapacity.Count == 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", capsCapacity)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
            else if (capsCapacity.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottlesCapacity)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
        }
    }
}
