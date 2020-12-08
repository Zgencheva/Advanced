using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace _06.ReverseAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int division = int.Parse(Console.ReadLine());
            Func<List<int>, List<int>> reverseList = list =>
            {
                List<int> reversedList = new List<int>();
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    reversedList.Add(list[i]);
                }
                return reversedList;

            };
            List<int> myList = reverseList(input);

            Func<int, bool> predicate = x => x % division != 0;
            myList = myList.Where(predicate).ToList();
            Console.WriteLine(string.Join(" ", myList));
        }

        static Func<int, bool> GetCondition(int num, int division)
        {

            return num => num % division == 0;



        }
    }
}
