using System;
using System.Linq;

namespace AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read from the console prices of items
            //Add VAT of 20 % to all of them

            Predicate<double> addVat = n => n == n + n * 0.2;
            double[] nums = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(n => n * 1.2)
                .ToArray();
            foreach (var price in nums)
                Console.WriteLine($"{price:f2}");

        }
    }
}
