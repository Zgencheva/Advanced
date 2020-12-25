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
            List<string> currentList = new List<string>();
            for (int i = 0; i < n; i++)
            {
                currentList.Add(Console.ReadLine());
            }
            int[] indexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
                
            Swap(currentList, indexes[0], indexes[1]);
        }

        public static void Swap<T>(List<T> list, int firstIn, int secondInd)
        {
            T medInd = list[firstIn];
            list[firstIn] = list[secondInd];
            list[secondInd] = medInd;

            foreach (var item in list)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }

    }
}
