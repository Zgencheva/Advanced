using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            SortedSet<string> uniqueEl = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine().Split().ToArray();
                for (int r = 0; r < elements.Length; r++)
                {
                    uniqueEl.Add(elements[r]);
                }

            }

            Console.WriteLine($"{string.Join(' ', uniqueEl)}");
        }
    }
}
