using System;
using System.Linq;

namespace FunctionalProgramming2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read numbers from the console
            //Use your own function to parse each element
            //Print the count of numbers
            //Print the sum

            Func<string, int> parser = n => int.Parse(n);
            int[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(parser)
                .ToArray();
            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers.Sum());

        }
    }
}
