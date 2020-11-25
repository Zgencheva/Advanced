using System;
using System.Collections.Generic;

namespace _5.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> chars = new SortedDictionary<char, int>();
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (!chars.ContainsKey(currentChar))
                {
                    chars.Add(currentChar, 0);
                }
                chars[currentChar]++;
            }

            foreach (var item in chars)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
