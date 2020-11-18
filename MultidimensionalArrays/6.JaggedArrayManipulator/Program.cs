using System;
using System.Linq;
using System.Threading;

namespace _6.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[][] jagged = new double[n][];

            FillJaggedArray(jagged);
            ManipulatingJagged(jagged);

            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                if (command[0] == "End")
                {
                    break;
                }
                else if (command[0] == "Add")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);
                    if (jagged.GetLength(0) > row && row >= 0)
                    {
                        if (jagged[row].Length > col && col >= 0)
                        {
                            jagged[row][col] = jagged[row][col] + value;
                        }
                    }
                }
                else if (command[0] == "Subtract")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);
                    if (jagged.GetLength(0) > row && row >= 0)
                    {
                        if (jagged[row].Length > col && col >= 0)
                        {
                            jagged[row][col] = jagged[row][col] - value;
                        }
                    }
                }
            }

            ReadJaggedMatrix(jagged);
        }

        private static void ManipulatingJagged(double[][] jagged)
        {
            for (int row = 0; row < jagged.Length - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] = jagged[row][col] * 2;
                        jagged[row + 1][col] = jagged[row + 1][col] * 2;
                    }
                }
                else
                {

                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] = jagged[row][col] / 2;

                    }
                    for (int col = 0; col < jagged[row + 1].Length; col++)
                    {

                        jagged[row + 1][col] = jagged[row + 1][col] / 2;
                    }
                }

            }
        }

        private static void FillJaggedArray(double[][] jagged)
        {
            for (int row = 0; row < jagged.Length; row++)
            {
                double[] rowData = Console.ReadLine()
                    .Split()
                    .Select(double.Parse)
                    .ToArray();
                jagged[row] = new double[rowData.Length];
                for (int col = 0; col < rowData.Length; col++)
                {
                    jagged[row][col] = rowData[col];
                }
            }
        }

        private static void ReadJaggedMatrix(double[][] jagged)
        {
            foreach (double[] row in jagged)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
