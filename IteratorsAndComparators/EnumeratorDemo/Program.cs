using System;
using System.Collections;
using System.Collections.Generic;

namespace EnumeratorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();

            // StringEnumerator enumerator = new StringEnumerator(array);
            //IEnumerator enumerator = array.GetEnumerator();
            List<int> number = new List<int> { 1, 2, 3 };
            var enumerator = number.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            foreach (var item in number)
            {
                Console.WriteLine(item);
            }
        }
    }
}
