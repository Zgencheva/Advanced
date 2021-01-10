using System;
using System.Linq;

namespace RecursiveArraySum
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(Sum(array, 0));

        }

        static int Sum(int[] array, int index)
        {
            
            if (array.Length - 1 == index)
            {
                return array[index];
            }

            int current = array[index] + Sum(array, index +1);
            return current;

            
        }
    }
}
