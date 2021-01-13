using System;
using System.Linq;

namespace Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countOfCommands = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            bool didHeWon = false;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string current = Console.ReadLine();
                
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = current[col];

                }
            }
            //Getting start possition
            int rowPossition = 0;
            int collPossition = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == 'f')
                    {
                        rowPossition = row;
                        collPossition = col;
                    }

                }
            }

            for (int i = 0; i < countOfCommands; i++)
            {
                string command = Console.ReadLine();
                matrix[rowPossition, collPossition] = '-';
                if (command == "up")
                {
                    if (rowPossition > 0)
                    {
                        rowPossition--;
                    }
                    else
                    {
                        rowPossition = n-1;
                    }

                    if (matrix[rowPossition, collPossition] == '-')
                    {
                        matrix[rowPossition, collPossition] = 'f';
                        
                    }
                    else if (matrix[rowPossition, collPossition] == 'T')
                    {
                        //moving down
                        if (rowPossition < n - 1)
                        {
                            rowPossition++;
                        }
                        else
                        {
                            rowPossition = 0;
                        }
                        matrix[rowPossition, collPossition] = 'f';
                    }
                    else if (matrix[rowPossition, collPossition] == 'B')
                    {
                        //giveBonus
                        if (rowPossition > 0)
                        {
                            rowPossition--;
                        }
                        else
                        {
                            rowPossition = n - 1;
                        }
                        if (matrix[rowPossition, collPossition] == '-')
                        {
                            matrix[rowPossition, collPossition] = 'f';
                        }
                        else if (matrix[rowPossition, collPossition] == 'F')
                        {
                            matrix[rowPossition, collPossition] = 'f';
                            didHeWon = true;
                            break;
                        }
                        else if (matrix[rowPossition, collPossition] == 'T')
                        {
                            //moving down
                            if (rowPossition < n - 1)
                            {
                                rowPossition++;
                            }
                            else
                            {
                                rowPossition = 0;
                            }
                            matrix[rowPossition, collPossition] = 'f';
                        }

                    }
                    else if (matrix[rowPossition, collPossition] == 'F')
                    {
                        matrix[rowPossition, collPossition] = 'f';
                        didHeWon = true;
                        break;
                    }
                }
                else if (command == "down")
                {
                    if (rowPossition < n -1)
                    {
                        rowPossition++;
                    }
                    else
                    {
                        rowPossition = 0;
                    }

                    if (matrix[rowPossition, collPossition] == '-')
                    {
                        matrix[rowPossition, collPossition] = 'f';
                    }
                    else if (matrix[rowPossition, collPossition] == 'T')
                    {
                        //moving up
                        if (rowPossition > 0)
                        {
                            rowPossition--;
                        }
                        else
                        {
                            rowPossition = n - 1;
                        }
                        matrix[rowPossition, collPossition] = 'f';
                    }
                    else if (matrix[rowPossition, collPossition] == 'B')
                    {
                        //giveBonus
                        if (rowPossition < n-1)
                        {
                            rowPossition++;
                        }
                        else
                        {
                            rowPossition = 0;
                        }
                        if (matrix[rowPossition, collPossition] == '-')
                        {
                            matrix[rowPossition, collPossition] = 'f';
                        }
                        else if (matrix[rowPossition, collPossition] == 'F')
                        {
                            matrix[rowPossition, collPossition] = 'f';
                            didHeWon = true;
                            break;
                        }
                        else if (matrix[rowPossition, collPossition] == 'T')
                        {
                            if (rowPossition > 0)
                            {
                                rowPossition--;
                            }
                            else
                            {
                                rowPossition = n - 1;
                            }
                            matrix[rowPossition, collPossition] = 'f';
                        }

                    }
                    else if (matrix[rowPossition, collPossition] == 'F')
                    {
                        matrix[rowPossition, collPossition] = 'f';
                        didHeWon = true;
                        break;
                    }
                }
                else if (command == "right")
                {
                    if (collPossition < n - 1)
                    {
                        collPossition++;
                    }
                    else
                    {
                        collPossition = 0;
                    }

                    if (matrix[rowPossition, collPossition] == '-')
                    {
                        matrix[rowPossition, collPossition] = 'f';
                    }
                    else if (matrix[rowPossition, collPossition] == 'T')
                    {
                        //movingLeft
                        if (collPossition > 0)
                        {
                            collPossition--;
                        }
                        else
                        {
                            collPossition = n - 1;
                        }
                        matrix[rowPossition, collPossition] = 'f';
                    }
                    else if (matrix[rowPossition, collPossition] == 'B')
                    {
                        //giveBonus
                        if (collPossition < n - 1)
                        {
                            collPossition++;
                        }
                        else
                        {
                            collPossition = 0;
                        }
                        if (matrix[rowPossition, collPossition] == '-')
                        {
                            matrix[rowPossition, collPossition] = 'f';
                        }
                        else if (matrix[rowPossition, collPossition] == 'F')
                        {
                            matrix[rowPossition, collPossition] = 'f';
                            didHeWon = true;
                            break;
                        }
                        else if (matrix[rowPossition, collPossition] == 'T')
                        {
                            //movingLeft
                            if (collPossition > 0)
                            {
                                collPossition--;
                            }
                            else
                            {
                                collPossition = n - 1;
                            }
                            matrix[rowPossition, collPossition] = 'f';
                        }

                    }
                    else if (matrix[rowPossition, collPossition] == 'F')
                    {
                        matrix[rowPossition, collPossition] = 'f';
                        didHeWon = true;
                        break;
                    }
                }
                else if (command == "left")
                {
                    if (collPossition > 0)
                    {
                        collPossition--;
                    }
                    else
                    {
                        collPossition = n - 1;
                    }

                    if (matrix[rowPossition, collPossition] == '-')
                    {
                        matrix[rowPossition, collPossition] = 'f';
                    }
                    else if (matrix[rowPossition, collPossition] == 'T')
                    {
                        if (collPossition < n - 1)
                        {
                            collPossition++;
                        }
                        else
                        {
                            collPossition = 0;
                        }
                        matrix[rowPossition, collPossition] = 'f';
                    }
                    else if (matrix[rowPossition, collPossition] == 'B')
                    {
                        //giveBonus
                        if (collPossition > 0)
                        {
                            collPossition--;
                        }
                        else
                        {
                            collPossition = n - 1;
                        }
                        if (matrix[rowPossition, collPossition] == '-')
                        {
                            matrix[rowPossition, collPossition] = 'f';
                        }
                        else if (matrix[rowPossition, collPossition] == 'F')
                        {
                            matrix[rowPossition, collPossition] = 'f';
                            didHeWon = true;
                            break;
                        }
                        else if (matrix[rowPossition, collPossition] == 'T')
                        {
                            if (collPossition < n - 1)
                            {
                                collPossition++;
                            }
                            else
                            {
                                collPossition = 0;
                            }
                            matrix[rowPossition, collPossition] = 'f';
                        }

                    }
                    else if (matrix[rowPossition, collPossition] == 'F')
                    {
                        matrix[rowPossition, collPossition] = 'f';
                        didHeWon = true;
                        break;
                    }
                }
            }
            if (didHeWon)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }
            //printing matrixz
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
