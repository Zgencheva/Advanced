using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace _2.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a line of integers separated by ", ".
            //Print on two lines the count of numbers and their sum.

            int[] array = Console.ReadLine().Split(", ").Select(ParseNumber).ToArray();
            //PrintResults(array, GetCount, GetSum);
            //PrintResults(array, GetCount, x =>
            //{
            //    return x.Sum();
            //});

            PrintResults(array, GetCount, x =>
            {
                int sum = 0;
                for (int i = 0; i < x.Length; i++)
                {
                    sum += x[i];
                }
                return sum;
            });
        }

        static int GetCount(int[] array)
        {
            return array.Length;
        }

        static int GetSum(int[] array)
        {
            return array.Sum();
        }

        static void PrintResults( int[] array, 
            Func<int[], int> count, 
            Func<int[], int> sum)
        {
            Console.WriteLine(count(array));
            Console.WriteLine(sum(array));
        }

        static int ParseNumber(string number)
        {
            return int.Parse(number);

        }
    }
}
