using System;
using System.Linq;

namespace _8.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = ReadMatrix(n, n);
            string[] input = Console.ReadLine().Split().ToArray();
            int currentActiveSells = 0;
            int sumActiveSells = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int[] currentInput = input[i].Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int currentRow = currentInput[0];
                int currentCol = currentInput[1];
                int bombPower = matrix[currentRow, currentCol];
                
                if (bombPower > 0)
                {

                    matrix[currentRow, currentCol] = 0;
                    bool canGoUp = false;
                    if (currentRow > 0)
                    {
                        canGoUp = true;
                        if (matrix[currentRow - 1, currentCol] > 0)
                        {

                        matrix[currentRow - 1, currentCol] = matrix[currentRow - 1, currentCol] - bombPower; 
                        }
                    }
                    bool canGoDown = false;
                    if (currentRow < n - 1)
                    {
                        canGoDown = true;
                        if (matrix[currentRow + 1, currentCol] > 0)
                        {

                        matrix[currentRow + 1, currentCol] = matrix[currentRow + 1, currentCol] - bombPower;
                        }
                    }
                    bool canGoRight = false;
                    if (currentCol < n-1)
                    {
                        canGoRight = true;
                        if (matrix[currentRow, currentCol + 1] > 0)
                        {

                        matrix[currentRow, currentCol + 1] = matrix[currentRow, currentCol + 1] - bombPower;
                        }
                    }
                    bool canGoLeft = false;
                    if (currentCol > 0)
                    {
                        canGoLeft = true;
                        if (matrix[currentRow, currentCol - 1] > 0)
                        {

                        matrix[currentRow, currentCol - 1] = matrix[currentRow, currentCol - 1] - bombPower;
                        }
                    }
                    if (canGoUp && canGoRight)
                    {
                        if (matrix[currentRow - 1, currentCol + 1] > 0)
                        {

                        matrix[currentRow - 1, currentCol + 1] = matrix[currentRow - 1, currentCol + 1] - bombPower;
                        }
                    }
                    if (canGoUp && canGoLeft)
                    {
                        if (matrix[currentRow - 1, currentCol - 1] > 0)
                        {

                        matrix[currentRow - 1, currentCol - 1] = matrix[currentRow - 1, currentCol - 1] - bombPower;
                        }
                    }
                    if (canGoDown && canGoRight)
                    {
                        if (matrix[currentRow + 1, currentCol + 1] > 0)
                        {

                        matrix[currentRow + 1, currentCol + 1] = matrix[currentRow + 1, currentCol + 1] - bombPower;
                        }
                    }
                    if (canGoDown && canGoLeft)
                    {
                        if (matrix[currentRow + 1, currentCol - 1] > 0)
                        {

                        matrix[currentRow + 1, currentCol - 1] = matrix[currentRow + 1, currentCol - 1] - bombPower;
                        }
                    }

                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        currentActiveSells++;
                        sumActiveSells += matrix[row, col];
                    }
                }
                
            }
            Console.WriteLine($"Alive cells: {currentActiveSells}");
            Console.WriteLine($"Sum: {sumActiveSells}");
            GetMatrix(matrix);
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

        static void GetMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
