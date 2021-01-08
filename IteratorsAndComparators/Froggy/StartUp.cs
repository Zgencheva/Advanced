using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Froggy
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] stones = Console.ReadLine()?.Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Lake lake = new Lake(stones);
            List<int> output = new List<int>();

            foreach (var item in lake)
            {
                output.Add(item);
            }

            Console.WriteLine(string.Join(", ", output));
        }
    }
}
