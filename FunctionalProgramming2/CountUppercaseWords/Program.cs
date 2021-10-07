using System;
using System.Linq;

namespace CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read a text from the console
            //Filter only words, that start with a capital letter
            //Use Predicate
            //Print each of the words on a new line

            Predicate<string> checker = n => n[0] == n.ToUpper()[0];
            string[] words = Console.ReadLine()
                .Split()
                .Where(w => checker(w))
                .ToArray();

            foreach (String item in words)
            {
                Console.WriteLine(item);
            }


        }
    }
}
