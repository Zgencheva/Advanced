using System;
using System.Linq;

namespace SuperMario
{
    class Program
    {
        static void Main(string[] args)
        {
            int lives = int.Parse(Console.ReadLine());
            int mazeSize = int.Parse(Console.ReadLine());
            int colSize = 0;
            int rowCoordinate = 0;
            int colCoordinate = 0;
            bool isAlive = true;
            bool isPrincessSaved = false;
            char[] firstRow = Console.ReadLine().ToCharArray();
            colSize = firstRow.Length;
            char[,] maze = new char[mazeSize, colSize];
            for (int col = 0; col < colSize; col++)
            {
                maze[0, col] = firstRow[col];
                if (maze[0, col] == 'M')
                {
                    rowCoordinate = 0;
                    colCoordinate = col;
                    maze[0, col] = '-';
                }
            }
            for (int row = 1; row < maze.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();

                for (int col = 0; col < maze.GetLength(1); col++)
                {
                    char currentChar = rowData[col];
                    maze[row, col] = rowData[col];
                    if (currentChar == 'M')
                    {
                        rowCoordinate = row;
                        colCoordinate = col;
                        maze[row, col] = '-';
                    }
                }
            }


            while (isAlive)
            {
                char[] currentMove = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                char direction = currentMove[0];
                int enemyRow = int.Parse(currentMove[1].ToString());
                int enemyCol = int.Parse(currentMove[2].ToString());
                maze[enemyRow, enemyCol] = 'B';
                lives--;
                //up
                if (direction == 'W')
                {
                    rowCoordinate--;
                    if (isValidCoordinate(maze, rowCoordinate, colCoordinate))
                    {
                        if (maze[rowCoordinate, colCoordinate] == 'B')
                        {
                            lives -= 2;
                            if (lives <= 0)
                            {
                                isAlive = false;
                                maze[rowCoordinate, colCoordinate] = 'X';
                            }
                            else
                            {
                                maze[rowCoordinate, colCoordinate] = '-';
                            }

                        }
                        else if (maze[rowCoordinate, colCoordinate] == 'P')
                        {
                            isPrincessSaved = true;
                            maze[rowCoordinate, colCoordinate] = '-';
                            break;
                        }

                    }
                    else
                    {
                        rowCoordinate++;
                    }

                }
                //down
                else if (direction == 'S')
                {
                    rowCoordinate++;
                    if (isValidCoordinate(maze, rowCoordinate, colCoordinate))
                    {
                        if (maze[rowCoordinate, colCoordinate] == 'B')
                        {
                            lives -= 2;
                            if (lives <= 0)
                            {
                                isAlive = false;
                                maze[rowCoordinate, colCoordinate] = 'X';
                            }
                            else
                            {
                                maze[rowCoordinate, colCoordinate] = '-';
                            }

                        }
                        else if (maze[rowCoordinate, colCoordinate] == 'P')
                        {
                            isPrincessSaved = true;
                            maze[rowCoordinate, colCoordinate] = '-';
                            break;
                        }

                    }
                    else
                    {
                        rowCoordinate--;
                    }
                }
                //left
                else if (direction == 'A')
                {
                    colCoordinate--;
                    if (isValidCoordinate(maze, rowCoordinate, colCoordinate))
                    {
                        if (maze[rowCoordinate, colCoordinate] == 'B')
                        {
                            lives -= 2;
                            if (lives <= 0)
                            {
                                isAlive = false;
                                maze[rowCoordinate, colCoordinate] = 'X';
                            }
                            else
                            {
                                maze[rowCoordinate, colCoordinate] = '-';
                            }

                        }
                        else if (maze[rowCoordinate, colCoordinate] == 'P')
                        {
                            isPrincessSaved = true;
                            maze[rowCoordinate, colCoordinate] = '-';
                            break;
                        }

                    }
                    else
                    {
                        colCoordinate++;
                    }
                }
                //right
                else if (direction == 'D')
                {
                    colCoordinate++;
                    if (isValidCoordinate(maze, rowCoordinate, colCoordinate))
                    {
                        if (maze[rowCoordinate, colCoordinate] == 'B')
                        {
                            lives -= 2;
                            if (lives <= 0)
                            {
                                isAlive = false;
                                maze[rowCoordinate, colCoordinate] = 'X';
                            }
                            else
                            {
                                maze[rowCoordinate, colCoordinate] = '-';
                            }

                        }
                        else if (maze[rowCoordinate, colCoordinate] == 'P')
                        {
                            isPrincessSaved = true;
                            maze[rowCoordinate, colCoordinate] = '-';
                            break;
                        }

                    }
                    else
                    {
                        colCoordinate--;
                    }
                }
                if (lives <= 0)
                {
                    isAlive = false;
                }
            }

            if (!isAlive)
            {
                Console.WriteLine($"Mario died at {rowCoordinate};{colCoordinate}.");
            }
            else
            {
                Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
            }
            PrintMatrix(maze);
        }
        static char[,] ReadMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    char currentChar = rowData[col];
                    matrix[row, col] = rowData[col];
                    if (currentChar == 'M')
                    {

                    }
                }
            }

            return matrix;
        }

        static void PrintMatrix(char[,] matrix)
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

        static bool isValidCoordinate(char[,] matrix, int row, int col)
        {
            if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(0))
            {
                return true;
            }
            return false;

        }


    }
}
