using System;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace _6.JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jagged = new int[n][];

            for (int row = 0; row < jagged.Length; row++)
            {
                int[] rowData = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                jagged[row] = new int[rowData.Length];
                for (int col = 0; col < rowData.Length; col++)
                {
                    jagged[row][col] = rowData[col];
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split()
                    .ToArray();
                
                string currentCommand = command[0];
                if (currentCommand == "END")
                {
                    break;
                }
                else if (currentCommand == "Add")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    if (0 <= row && row <= jagged.Length-1)
                    {
                        if (0<= col && col <= jagged[row].Length - 1)
                        {
                            jagged[row][col] += int.Parse(command[3]);
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                        continue;
                    }
                }
                else if (currentCommand == "Subtract")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    if (0 <= row && row <= jagged.Length - 1)
                    {
                        if (0 <= col && col <= jagged[row].Length - 1)
                        {
                            jagged[row][col] -= int.Parse(command[3]);
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                        continue;
                    }
                }
            }
            ReadJaggedMatrix(jagged);

        }

        private static void ReadJaggedMatrix(int[][] jagged)
        {
            foreach (int[] row in jagged)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
