using System;
using System.Linq;

namespace _3.CountUppercaseWords2
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> checker = n => n[0] == n.ToUpper()[0];
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(checker)
                .ToArray();
            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
