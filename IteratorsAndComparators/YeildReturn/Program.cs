using System;
using System.Collections.Generic;

namespace YieldReturn
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
            yield return "Peshka";
            Console.WriteLine("sled Peshka sym");
            yield return "dimitrichka";
        }
    }
}
