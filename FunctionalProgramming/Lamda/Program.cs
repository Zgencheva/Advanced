using System;
using System.Linq;

namespace Lamda
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            numbers = numbers.Where((x, index) =>
            {
                Console.WriteLine($"Index is {index}");
                Console.WriteLine($"X : {x} -> {x % 2 == 0}");
                return x % 2 == 0;
            }).ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
