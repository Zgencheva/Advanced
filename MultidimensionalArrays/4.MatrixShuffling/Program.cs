using System;
using System.Data;
using System.Linq;

namespace _4.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] measures = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = measures[0];
            int cols = measures[1];
            string[,] matrix = ReadMatrix(rows, cols);
            bool isTheoperationValid = false;
            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                if (command[0] == "END")
                {
                    break;
                }
                if (command[0] == "swap" && command.Length == 5)
                {
                    if (int.Parse(command[1]) < matrix.GetLength(0) 
                        && int.Parse(command[2]) < matrix.GetLength(1) 
                        && int.Parse(command[3]) < matrix.GetLength(0) 
                        && int.Parse(command[4]) < matrix.GetLength(1))
                    {
                        isTheoperationValid = true;
                    }
                    else
                    {
                        isTheoperationValid = false;
                    }
                }
                else
                {
                    isTheoperationValid = false;
                }
                if (!isTheoperationValid)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    int row1 = int.Parse(command[1]);
                    int col1 = int.Parse(command[2]);
                    int row2 = int.Parse(command[3]);
                    int col2 = int.Parse(command[4]);
                    string savedElement = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = savedElement;
                    GetMatrix(matrix);
                }
               
            }

        }

        static string[,] ReadMatrix(int rows, int cols)
        {
            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            return matrix;
        }

        static void GetMatrix(string[,] matrix)
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
