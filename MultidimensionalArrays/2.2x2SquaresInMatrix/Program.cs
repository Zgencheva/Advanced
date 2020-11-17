using System;
using System.Linq;

namespace _2._2x2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] measures = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = measures[0]; 
            int cols = measures[1];
            char[,] matrix = ReadMatrix(rows, cols);
            int counter = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    char currentChar = matrix[row, col];
                    if (currentChar == matrix[row, col + 1]) 
                        //&& (matrix[row, col] == matrix[row + 1, col]) 
                        //&& (matrix[row, col] == matrix[row + 1, col + 1]))
                    {
                        if (currentChar == matrix[row + 1, col])
                        {
                            if (currentChar == matrix[row + 1, col + 1])
                            {
                                counter++;
                            }
                        }
                        
                    }
                }
            }

            Console.WriteLine(counter);

        }

        static char[,] ReadMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
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
