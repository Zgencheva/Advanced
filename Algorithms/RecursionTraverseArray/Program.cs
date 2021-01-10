using System;

namespace RecursionTraverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {1, 2, 3 };
            Traverse(array, 0);
        }

        static void Traverse<T>(T[] array, int index)
        {
            if (array.Length == index)
            {
                return;
            }

            Console.WriteLine(array[index]);
            Traverse(array, index+1);
            Console.WriteLine("After recursion");
            Console.WriteLine(array[index]);
        }
    }
}
