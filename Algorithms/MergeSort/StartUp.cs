using System;
using System.Linq;

namespace MergeSort
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(BinarySearch(array, number, 0, array.Length ));
        }

        private static int BinarySearch(int[] array, int number, int start, int end)
        {
            int middle = (start + end) / 2;

            //number nor found
            if (start > end)
            {
                return -1;
            }
            //move to the left
            if (number < array[middle])
            {
                return BinarySearch(array, number, start, middle - 1);
            }
            //move to the right
            else if (number > array[middle])
            {
                return BinarySearch(array, number, middle+ 1, end);
            }
            else
            {
                return middle;
            }
        
        }
    }
}
