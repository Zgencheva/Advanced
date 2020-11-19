using System;
using System.Linq;

namespace _9_Minner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split().ToArray();
            char[,] matrix = ReadMatrix(n,n);
            int coals = GetTotalCoals(matrix);
            bool areAllCoalsCollected = false;
            for (int i = 0; i < commands.Length; i++)
            {
                if (coals == 0)
                {
                    areAllCoalsCollected = true;
                    break;
                }
            }

            if (coals > 0)
            {
                Console.WriteLine($"{coals} coals left. (5, 0)");
            }

        }

        static char[,] ReadMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine()
                .Split()
                .Select(char.Parse)
                .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            return matrix;
        }

        static int GetTotalCoals(char[,] matrix)
        {
            
            int totalCoals = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'c')
                    {
                        totalCoals++;
                    }
                }
            }

            return totalCoals;
        }


    }
}
