using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> func = n => n.Min();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(func(input));


        }
    }
}
