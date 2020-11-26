using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string color = input[0];
                string[] clothes = input[1].Split(',').ToArray();
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                for (int r = 0; r < clothes.Length; r++)
                {
                    if (!wardrobe[color].ContainsKey(clothes[r]))
                    {
                        wardrobe[color].Add(clothes[r], 0);
                    }
                    wardrobe[color][clothes[r]]++;
                }
                
            }

            string[] toFound = Console.ReadLine().Split().ToArray();
            string colorToFound = toFound[0];
            string dressToFound = toFound[1];
            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var dress in item.Value)
                {
                    if (item.Key == colorToFound && dress.Key == dressToFound)
                    {
                        Console.WriteLine($"* {dress.Key} - {dress.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {dress.Key} - {dress.Value}");
                    }
                }
            }
        }
    }
}
