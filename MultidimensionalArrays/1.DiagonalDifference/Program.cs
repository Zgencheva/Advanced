using System;
using System.Linq;

namespace _1.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = ReadMatrix(n, n);

            int sumPrimaryDiagonal = 0;
            int sumSecondaryDiagonal = 0;
            int initialNum = matrix.GetLength(0) - 1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int currNum = matrix[row, col];
                    
                    if (row == col)
                    {
                        sumPrimaryDiagonal += currNum;
                    }
                }
                sumSecondaryDiagonal += matrix[row, initialNum];
                initialNum--;
            }
            Console.WriteLine(Math.Abs(sumSecondaryDiagonal -sumPrimaryDiagonal));
        }

        static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            return matrix;
        }
    }
}
