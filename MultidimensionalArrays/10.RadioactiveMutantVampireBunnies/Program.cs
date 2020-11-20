using System;
using System.Data;
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
            string directions = Console.ReadLine();
            bool doesThePlayerEscaped = false;
            bool doesThePlayerDied = false;
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

            for (int i = 0; i < directions.Length; i++)
            {
                char currentDirrection = directions[i];
                if (currentDirrection == 'R')
                {
                    if (collPossition == m - 1)
                    {
                        doesThePlayerEscaped = true;
                        matrix[rowPossition, collPossition] = '.';
                    }
                    else
                    {
                        matrix[rowPossition, collPossition] = '.';
                        collPossition++;
                    }
                }
                else if (currentDirrection == 'L')
                {
                    if (collPossition == 0)
                    {
                        doesThePlayerEscaped = true;
                        matrix[rowPossition, collPossition] = '.';
                    }
                    else
                    {
                        matrix[rowPossition, collPossition] = '.';
                        collPossition--;
                    }
                }
                else if (currentDirrection == 'U')
                {
                    if (rowPossition == 0)
                    {
                        doesThePlayerEscaped = true;
                        matrix[rowPossition, collPossition] = '.';
                        
                    }
                    else
                    {
                        matrix[rowPossition, collPossition] = '.';
                        rowPossition--;
                        //matrix[rowPossition - 1, collPossition] = 'P';
                    }
                }
                else if (currentDirrection == 'D')
                {
                    if (rowPossition == n - 1)
                    {
                        doesThePlayerEscaped = true;
                        matrix[rowPossition, collPossition] = '.';
                    }
                    else
                    {
                        matrix[rowPossition, collPossition] = '.';
                        rowPossition++;

                    }
                }
                //does the players turn into a bunny and die
                if (matrix[rowPossition, collPossition] == 'B')
                {
                    doesThePlayerDied = true;
                    matrix[rowPossition, collPossition] = '.';
                }
                else
                {
                    matrix[rowPossition, collPossition] = 'P';
                }
                for (int rows = 0; rows < n; rows++)
                {
                    for (int cols = 0; cols < m; cols++)
                    {
                        char currentMove = matrix[rows, cols];
                        if (currentMove == 'B')
                        {
                            if (rows > 0)
                            {
                                if (matrix[rows - 1, cols] == 'P')
                                {
                                    doesThePlayerDied = true;
                                }
                                else if (matrix[rows - 1, cols] == '.')
                                {
                                    matrix[rows - 1, cols] = 'b';
                                }
                                matrix[rows - 1, cols] = 'b';
                            }
                            if (rows < n - 1)
                            {
                                if (matrix[rows + 1, cols] == 'P')
                                {
                                    doesThePlayerDied = true;
                                }
                                else if (matrix[rows + 1, cols] == '.')
                                {

                                matrix[rows + 1, cols] = 'b';
                                }
                            }
                            if (cols > 0)
                            {
                                if (matrix[rows, cols - 1] == 'P')
                                {
                                    doesThePlayerDied = true;
                                }
                                else if (matrix[rows, cols - 1] == '.')
                                {

                                matrix[rows, cols - 1] = 'b';
                                }
                            }
                            if (cols < m - 1)
                            {
                                if (matrix[rows, cols + 1] == 'P')
                                {
                                    doesThePlayerDied = true;
                                }
                                else if (matrix[rows, cols + 1] == '.')
                                {

                                matrix[rows, cols + 1] = 'b';
                                }
                            }
                        }
                    }
                }

                for (int rows2 = 0; rows2 < n; rows2++)
                {
                    for (int cols2 = 0; cols2 < m; cols2++)
                    {
                        if (matrix[rows2, cols2] == 'b')
                        {
                            matrix[rows2, cols2] = 'B';
                        }
                    }
                }
                
                if (doesThePlayerEscaped)
                {
                    
                    matrix[rowPossition, collPossition] = '.';
                    break;
                }
                else if (doesThePlayerDied)
                {
                    
                    break;
                }
            }
            GetMatrix(matrix);
            if (doesThePlayerEscaped)
            {
                Console.WriteLine($"won: {rowPossition} {collPossition}");
            }
            else if (doesThePlayerDied)
            {
                Console.WriteLine($"dead: {rowPossition} {collPossition}");
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

        static void GetMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
