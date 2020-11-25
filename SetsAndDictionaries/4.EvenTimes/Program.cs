using System;
using System.Collections.Generic;

namespace _4.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (!dictionary.ContainsKey(currentNum))
                {
                    dictionary.Add(currentNum, 0);
                }
                dictionary[currentNum]++;
               
            }
            foreach (var item in dictionary)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
