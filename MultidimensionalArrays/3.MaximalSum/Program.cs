using System;
using System.Linq;

namespace _3.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] measures = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = measures[0];
            int cols = measures[1];
            int[,] matrix = ReadMatrix(rows, cols);
            int maxSum = int.MinValue;
            int TheRow = 0;
            int TheCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {

                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        TheRow = row;
                        TheCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[TheRow, TheCol]} {matrix[TheRow, TheCol + 1]} {matrix[TheRow, TheCol + 2]}");
            Console.WriteLine($"{matrix[TheRow + 1, TheCol]} {matrix[TheRow + 1, TheCol + 1]} {matrix[TheRow + 1, TheCol + 2]}");
            Console.WriteLine($"{matrix[TheRow + 2, TheCol]} {matrix[TheRow + 2, TheCol + 1]} {matrix[TheRow + 2, TheCol + 2]}");
        }

        static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
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
