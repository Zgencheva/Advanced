using System;
using System.Linq;

namespace _02.KnightsOfHonnor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split().Select(n => $"Sir {n}").ToArray();
           
            Action<string[]> print = n => Console.WriteLine(string.Join(Environment.NewLine, n));
                     
            print(names);
        }
    }
}
