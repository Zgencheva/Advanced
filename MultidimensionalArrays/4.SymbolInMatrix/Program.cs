using System;
using System.Linq;

namespace _4.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizes = int.Parse(Console.ReadLine());
            //int[,] matrix = ReadMatrix(sizes, sizes);

            char[,] matrix = new char[sizes, sizes];
            bool doesTheSymbolExist = false;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();
                
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            char symbol = char.Parse(Console.ReadLine());
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        doesTheSymbolExist = true;
                        Console.WriteLine($"({row}, {col})");
                        break;
                    }
                }
                if (doesTheSymbolExist)
                {
                    break;
                }
            }
            if (!doesTheSymbolExist)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
