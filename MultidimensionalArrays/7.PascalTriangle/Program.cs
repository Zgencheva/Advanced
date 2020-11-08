using System;

namespace _7.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cols = 1;
            long[][] pascal = new long[n][];
            for (int row = 0; row < n; row++)
            {
                pascal[row] = new long[cols];
                pascal[row][0] = 1;
                pascal[row][pascal[row].Length - 1] = 1;
                if (row > 1)
                {
                    for (int col = 1; col < pascal[row].Length - 1; col++)
                    {
                        long[] previousRow = pascal[row - 1];
                        long firstNum = previousRow[col];
                        long secondNum = previousRow[col - 1];
                        pascal[row][col] = firstNum + secondNum;

                    }
                }
                cols++;

            }
            for (int row = 0; row < pascal.Length; row++)
            {
                for (int col = 0; col < pascal[row].Length; col++)
                {
                    Console.Write(pascal[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
                
    }
}
