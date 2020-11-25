using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();
            
            for (int i = 0; i < input[0]; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                set1.Add(currentNum);
            }
            for (int i = 0; i < input[1]; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                set2.Add(currentNum);
            }

            var C = set1.Intersect(set2);
            Console.WriteLine(string.Join(' ', C));
        }
    }
}
