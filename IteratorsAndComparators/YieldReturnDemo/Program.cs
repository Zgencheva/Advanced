using System;
using System.Collections.Generic;

namespace YieldReturnDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var name in GetNames())
            {
                Console.WriteLine(name);
            }
        }

        public static IEnumerable<string> GetNames()
        {
            yield return "Goshko";
            yield return "Pesho";
            Console.WriteLine("sled pesho sym");
            Console.WriteLine("sled pesho sym");
            Console.WriteLine("sled pesho sym");
            yield return "dimitrichka";
        }
    }
}
