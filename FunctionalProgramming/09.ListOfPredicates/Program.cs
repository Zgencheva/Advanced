using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).Distinct().ToList();

            Console.WriteLine(string.Join(" ", GetDivisibleNums(n, nums)));
           
        }

        static List<int> GetDivisibleNums(int n, List<int> divisions)
        {
            List<int> output = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                Func<int, bool> predicate = x => i % x != 0;
                bool isDivisble = true;
                foreach (var item in divisions)
                {
                    if (predicate(item))
                    {
                        isDivisble = false;
                        break;
                    }
                }
                if (isDivisble)
                {
                    output.Add(i);
                }
            }

            return output;

        }


    }
}
