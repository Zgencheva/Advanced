using System;
using System.Linq;

namespace TheBattleOfTheFiveArmies
{
    class Program
    {
        static void Main(string[] args)
        {
            int armorOfArmy = int.Parse(Console.ReadLine());
            int mapSize = int.Parse(Console.ReadLine());
            int colSize = 0;
            int rowCoordinate = 0;
            int colCoordinate = 0;
            bool isAlive = true;
            //bool mordorSaved = false;
            char[] firstRow = Console.ReadLine().ToCharArray();
            colSize = firstRow.Length;
            char[,] map = new char[mapSize, colSize];
            for (int col = 0; col < colSize; col++)
            {
                map[0, col] = firstRow[col];
                if (map[0, col] == 'A')
                {
                    rowCoordinate = 0;
                    colCoordinate = col;
                    map[0, col] = '-';
                }
            }
            for (int row = 1; row < map.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();

                for (int col = 0; col < map.GetLength(1); col++)
                {
                    char currentChar = rowData[col];
                    map[row, col] = rowData[col];
                    if (currentChar == 'A')
                    {
                        rowCoordinate = row;
                        colCoordinate = col;
                        map[row, col] = '-';
                    }
                }
            }

            while (isAlive)
            {
                string[] currentMove = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    
                    
                string direction = currentMove[0];
                int enemyRow = int.Parse(currentMove[1].ToString());
                int enemyCol = int.Parse(currentMove[2].ToString());
                map[enemyRow, enemyCol] = 'O';
                armorOfArmy--;
                //up
                if (direction == "up")
                {
                    rowCoordinate--;
                    if (isValidCoordinate(map, rowCoordinate, colCoordinate))
                    {
                        if (map[rowCoordinate, colCoordinate] == 'O')
                        {
                            armorOfArmy -= 2;
                            if (armorOfArmy <= 0)
                            {
                                isAlive = false;
                                map[rowCoordinate, colCoordinate] = 'X';
                            }
                            else
                            {
                                map[rowCoordinate, colCoordinate] = '-';
                            }

                        }
                        else if (map[rowCoordinate, colCoordinate] == 'M')
                        {
                            //mordorSaved = true;
                            map[rowCoordinate, colCoordinate] = '-';
                            break;
                        }

                    }
                    else
                    {
                        rowCoordinate++;
                    }

                }
                //down
                else if (direction == "down")
                {
                    rowCoordinate++;
                    if (isValidCoordinate(map, rowCoordinate, colCoordinate))
                    {
                        if (map[rowCoordinate, colCoordinate] == 'O')
                        {
                            armorOfArmy -= 2;
                            if (armorOfArmy <= 0)
                            {
                                isAlive = false;
                                map[rowCoordinate, colCoordinate] = 'X';
                            }
                            else
                            {
                                map[rowCoordinate, colCoordinate] = '-';
                            }

                        }
                        else if (map[rowCoordinate, colCoordinate] == 'M')
                        {
                            //mordorSaved = true;
                            map[rowCoordinate, colCoordinate] = '-';
                            break;
                        }

                    }
                    else
                    {
                        rowCoordinate--;
                    }
                }
                //left
                else if (direction == "left")
                {
                    colCoordinate--;
                    if (isValidCoordinate(map, rowCoordinate, colCoordinate))
                    {
                        if (map[rowCoordinate, colCoordinate] == 'O')
                        {
                            armorOfArmy -= 2;
                            if (armorOfArmy <= 0)
                            {
                                isAlive = false;
                                map[rowCoordinate, colCoordinate] = 'X';
                            }
                            else
                            {
                                map[rowCoordinate, colCoordinate] = '-';
                            }

                        }
                        else if (map[rowCoordinate, colCoordinate] == 'M')
                        {
                            //mordorSaved = true;
                            map[rowCoordinate, colCoordinate] = '-';
                            break;
                        }

                    }
                    else
                    {
                        colCoordinate++;
                    }
                }
                //right
                else if (direction == "right")
                {
                    colCoordinate++;
                    if (isValidCoordinate(map, rowCoordinate, colCoordinate))
                    {
                        if (map[rowCoordinate, colCoordinate] == 'O')
                        {
                            armorOfArmy -= 2;
                            if (armorOfArmy <= 0)
                            {
                                isAlive = false;
                                map[rowCoordinate, colCoordinate] = 'X';
                            }
                            else
                            {
                                map[rowCoordinate, colCoordinate] = '-';
                            }

                        }
                        else if (map[rowCoordinate, colCoordinate] == 'M')
                        {
                            //mordorSaved = true;
                            map[rowCoordinate, colCoordinate] = '-';
                            break;
                        }

                    }
                    else
                    {
                        colCoordinate--;
                    }
                }
                if (armorOfArmy <= 0)
                {
                    isAlive = false;
                }
            }

            if (!isAlive)
            {
                Console.WriteLine($"The army was defeated at {rowCoordinate};{colCoordinate}.");
            }
            else
            {
                Console.WriteLine($"The army managed to free the Middle World! Armor left: {armorOfArmy}");
            }
            PrintMatrix(map);
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
