using System;
using System.Linq;

namespace _10.RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] measures = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = measures[0];
            int m = measures[1];
            char[,] matrix = ReadMatrix(n,m);
            int rowPossition = 0;
            int collPossition = 0;
            //Getting the start possition of the player
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    if (matrix[row, col] == 'P')
                    {
                        rowPossition = row;
                        collPossition = col;
                    }

                }
            }

            
        }

        static char[,] ReadMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string rowData = Console.ReadLine();
               
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            return matrix;
        }
    }
}
