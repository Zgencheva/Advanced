using System;
using System.Diagnostics.Tracing;
using System.Linq;

namespace _7.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = ReadMatrix(n, n);
            int maxStrikes = int.MinValue;
            int rowPossition = 0;
            int colPossition = 0;
            bool AreThereKnightsLeft = true;
            int counter = 0;
            while (AreThereKnightsLeft)
            {
                int totalStrikesForTheMatrix = 0;
                for (int rows = 0; rows < matrix.GetLength(0); rows++)
                {
                    for (int cols = 0; cols < matrix.GetLength(1); cols++)
                    {
                        if (matrix[rows, cols] == '0')
                        {
                            continue;
                        }
                        int strikes = 0;
                        bool possition1 = false; //two left, one up
                        if (cols - 2 >= 0 && rows - 1 >= 0)
                        {
                            possition1 = true;
                            if (matrix[rows - 1, cols - 2] == 'K')
                            {
                                strikes++;
                                totalStrikesForTheMatrix++;
                            }
                        }

                        bool possition2 = false; //two up, one left
                        if (rows - 2 >= 0 && cols - 1 >= 0)
                        {
                            possition2 = true;
                            if (matrix[rows - 2, cols - 1] == 'K')
                            {
                                strikes++;
                                totalStrikesForTheMatrix++;
                            }
                        }
                        bool possition3 = false; //two up, one right
                        if (rows - 2 >= 0 && cols + 1 < n)
                        {
                            possition3 = true;
                            if (matrix[rows - 2, cols + 1] == 'K')
                            {
                                strikes++;
                                totalStrikesForTheMatrix++;
                            }

                        }
                        bool possition4 = false; //two right, one up
                        if (rows - 1 >= 0 && cols + 2 < n)
                        {
                            possition4 = true;
                            if (matrix[rows - 1, cols + 2] == 'K')
                            {
                                strikes++;
                                totalStrikesForTheMatrix++;
                            }

                        }

                        bool possition5 = false; //two right, one down
                        if (rows + 1 < n && cols + 2 < n)
                        {
                            possition5 = true;
                            if (matrix[rows + 1, cols + 2] == 'K')
                            {
                                strikes++;
                                totalStrikesForTheMatrix++;
                            }

                        }
                        bool possition6 = false; //one right, two down
                        if (rows + 2 < n && cols + 1 < n)
                        {
                            possition6 = true;
                            if (matrix[rows + 2, cols + 1] == 'K')
                            {
                                strikes++;
                                totalStrikesForTheMatrix++;
                            }

                        }

                        bool possition7 = false; //two down, one left
                        if (rows + 2 < n && cols - 1 >= 0)
                        {
                            possition7 = true;
                            if (matrix[rows + 2, cols - 1] == 'K')
                            {
                                strikes++;
                                totalStrikesForTheMatrix++;
                            }

                        }
                        bool possition8 = false; //one down, two left

                        if (rows + 1 < n && cols - 2 >= 0)
                        {
                            possition8 = true;
                            if (matrix[rows + 1, cols - 2] == 'K')
                            {
                                strikes++;
                                totalStrikesForTheMatrix++;
                            }

                        }

                        if (strikes > maxStrikes)
                        {
                            maxStrikes = strikes;
                            rowPossition = rows;
                            colPossition = cols;

                        }

                    }
                }
                if (totalStrikesForTheMatrix == 0)
                {
                    AreThereKnightsLeft = false;
                }
                else
                {
                    matrix[rowPossition, colPossition] = '0';
                    counter++;
                    maxStrikes = 0;
                    rowPossition = 0;
                    colPossition = 0;
                }

            }
            Console.WriteLine(counter);
            
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

        static void GetMatrix(char[,] matrix)
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
