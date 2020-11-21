using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> dictionary = new Dictionary<double, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                double currentNum = nums[i];
                if (!dictionary.ContainsKey(currentNum))
                {
                    dictionary.Add(currentNum, 0);
                }
                dictionary[currentNum]++;
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
