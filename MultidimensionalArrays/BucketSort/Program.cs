using System;

namespace BucketSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = new int[] { 15, 17, 20, 29, 99 };
            int[] sorted = new int[100];
            for (int i = 0; i < ages.Length; i++)
            {
                int num = ages[0];
                sorted[num] = num;
            }
        }
    }
}
