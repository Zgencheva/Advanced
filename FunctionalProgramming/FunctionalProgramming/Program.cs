using System;
using System.Linq;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {1, 2, 3, 4, 5 };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (CheckEven(numbers[i]))
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            Console.WriteLine();
            numbers = numbers.Where(number => number % 2 == 0).ToArray();
            //same 
            numbers = numbers.Where(CheckEven).ToArray();
            Console.WriteLine(string.Join(" ", numbers));
        }

        //functional
        static bool CheckEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
