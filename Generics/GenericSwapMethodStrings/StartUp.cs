using GenericBoxofString;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();
            for (int i = 0; i < n; i++)
            {
                box.List.Add(int.Parse(Console.ReadLine()));

            }
            int[] possitions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstIndex = possitions[0];
            int secondIndex = possitions[1];

            box.Swap(box.List, firstIndex, secondIndex);
            Console.WriteLine(box.ToString());

        }

        


    }
}
