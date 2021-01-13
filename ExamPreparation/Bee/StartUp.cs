using System;

namespace Bee
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            char[,] matrix = new char[n, n];
            int pollinatedFlowers = 0;
         
            //bool didHeWon = false;
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
                    if (matrix[row, col] == 'B')
                    {
                        rowPossition = row;
                        collPossition = col;
                    }

                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                if (command == "up")
                {
                    //matrix = MovingUp(matrix, rowPossition, collPossition, pollinatedFlowers, didTheBeeWentOut);
                    matrix[rowPossition, collPossition] = '.';
                    if (rowPossition > 0)
                    {
                        rowPossition--;
                        if (matrix[rowPossition, collPossition] == '.')
                        {
                            matrix[rowPossition, collPossition] = 'B';
                        }
                        else if (matrix[rowPossition, collPossition] == 'f')
                        {
                            matrix[rowPossition, collPossition] = 'B';
                            pollinatedFlowers++;
                        }
                        else if (matrix[rowPossition, collPossition] == 'O')
                        {
                            //matrix[rowPossition, collPossition] = 'B';
                            matrix[rowPossition, collPossition] = '.';
                            if (rowPossition > 0)
                            {
                                rowPossition--;
                                if (matrix[rowPossition, collPossition] == '.')
                                {
                                    matrix[rowPossition, collPossition] = 'B';
                                }
                                else if (matrix[rowPossition, collPossition] == 'f')
                                {
                                    matrix[rowPossition, collPossition] = 'B';
                                    pollinatedFlowers++;
                                }

                            }
                            else
                            {
                                
                                Console.WriteLine("The bee got lost!");
                                break;
                            }

                        }
                        else
                        {

                            Console.WriteLine("The bee got lost!");
                            break;
                        }


                    }
                }
                else if (command == "down")
                {
                    //matrix = MovingDown(matrix, rowPossition, collPossition, pollinatedFlowers, didTheBeeWentOut);
                    matrix[rowPossition, collPossition] = '.';
                    if (rowPossition < matrix.GetLength(0) - 1)
                    {
                        rowPossition++;
                        if (matrix[rowPossition, collPossition] == '.')
                        {
                            matrix[rowPossition, collPossition] = 'B';
                        }
                        else if (matrix[rowPossition, collPossition] == 'f')
                        {
                            matrix[rowPossition, collPossition] = 'B';
                            pollinatedFlowers++;
                        }
                        else if (matrix[rowPossition, collPossition] == 'O')
                        {
                            matrix[rowPossition, collPossition] = '.';
                            if (rowPossition < matrix.GetLength(0) - 1)
                            {
                                rowPossition++;
                                if (matrix[rowPossition, collPossition] == '.')
                                {
                                    matrix[rowPossition, collPossition] = 'B';
                                }
                                else if (matrix[rowPossition, collPossition] == 'f')
                                {
                                    matrix[rowPossition, collPossition] = 'B';
                                    pollinatedFlowers++;
                                }
                               

                            }
                            else
                            {
                                Console.WriteLine("The bee got lost!");
                                break;
                            }

                        }

                    }
                    else
                    {

                        Console.WriteLine("The bee got lost!");
                        break;
                    }


                }
                else if (command == "left")
                {
                    //matrix = MovingLeft(matrix, rowPossition, collPossition, pollinatedFlowers, didTheBeeWentOut);
                    matrix[rowPossition, collPossition] = '.';
                    if (collPossition > 0)
                    {
                        collPossition--;
                        if (matrix[rowPossition, collPossition] == '.')
                        {
                            matrix[rowPossition, collPossition] = 'B';
                        }
                        else if (matrix[rowPossition, collPossition] == 'f')
                        {
                            matrix[rowPossition, collPossition] = 'B';
                            pollinatedFlowers++;
                        }
                        else if (matrix[rowPossition, collPossition] == 'O')
                        {
                            matrix[rowPossition, collPossition] = '.';
                            if (collPossition > 0)
                            {
                                collPossition--;
                                if (matrix[rowPossition, collPossition] == '.')
                                {
                                    matrix[rowPossition, collPossition] = 'B';
                                }
                                else if (matrix[rowPossition, collPossition] == 'f')
                                {
                                    matrix[rowPossition, collPossition] = 'B';
                                    pollinatedFlowers++;
                                }
                                

                            }
                            else
                            {

                                Console.WriteLine("The bee got lost!");
                                break;
                            }

                        }

                    }
                    else
                    {

                        Console.WriteLine("The bee got lost!");
                        break;
                    }

                }
                else if (command == "right")
                {
                    //matrix = MovingRight(matrix, rowPossition, collPossition, pollinatedFlowers, didTheBeeWentOut);
                    matrix[rowPossition, collPossition] = '.';
                    if (collPossition < n - 1)
                    {
                        collPossition++;
                        if (matrix[rowPossition, collPossition] == '.')
                        {
                            matrix[rowPossition, collPossition] = 'B';
                        }
                        else if (matrix[rowPossition, collPossition] == 'f')
                        {
                            matrix[rowPossition, collPossition] = 'B';
                            pollinatedFlowers++;
                        }
                        else if (matrix[rowPossition, collPossition] == 'O')
                        {
                            matrix[rowPossition, collPossition] = '.';
                            if (collPossition < n-1)
                            {
                                collPossition++;
                                if (matrix[rowPossition, collPossition] == '.')
                                {
                                    matrix[rowPossition, collPossition] = 'B';
                                }
                                else if (matrix[rowPossition, collPossition] == 'f')
                                {
                                    matrix[rowPossition, collPossition] = 'B';
                                    pollinatedFlowers++;
                                }
                               
                            }
                            else
                            {

                                Console.WriteLine("The bee got lost!");
                                break;

                            }

                        }

                    }
                    else
                    {

                        Console.WriteLine("The bee got lost!");
                        break;

                    }

                }

                
            }
            if (pollinatedFlowers >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {pollinatedFlowers} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - pollinatedFlowers} flowers more");
            }

            //printMatrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }

            static char[,] MovingUp(char[,] matrix, int rowPossition, int collPossition, int collectedFlowers, bool didTheBeeGoOut)
            {

                matrix[rowPossition, collPossition] = '.';
                if (rowPossition > 0)
                {
                    rowPossition--;
                    if (matrix[rowPossition, collPossition] == '.')
                    {
                        matrix[rowPossition, collPossition] = 'B';
                    }
                    else if (matrix[rowPossition, collPossition] == 'f')
                    {
                        matrix[rowPossition, collPossition] = 'B';
                        collectedFlowers++;
                    }
                    else if (matrix[rowPossition, collPossition] == 'O')
                    {
                        matrix[rowPossition, collPossition] = 'B';
                        MovingUp(matrix, rowPossition, collPossition, collectedFlowers, didTheBeeGoOut);
                    }

                }
                else
                {
                    didTheBeeGoOut = true;
                    return matrix;
                }

                return matrix;
            }

            static char[,] MovingDown(char[,] matrix, int rowPossition, int collPossition, int collectedFlowers, bool didTheBeeGoOut)
            {
                matrix[rowPossition, collPossition] = '.';
                if (rowPossition < matrix.GetLength(0) -1)
                {
                    rowPossition++;
                    if (matrix[rowPossition, collPossition] == '.')
                    {
                        matrix[rowPossition, collPossition] = 'B';
                    }
                    else if (matrix[rowPossition, collPossition] == 'f')
                    {
                        matrix[rowPossition, collPossition] = 'B';
                        collectedFlowers++;
                    }
                    else if (matrix[rowPossition, collPossition] == 'O')
                    {
                        matrix[rowPossition, collPossition] = 'B';
                        MovingDown(matrix, rowPossition, collPossition, collectedFlowers, didTheBeeGoOut);
                    }

                }
                else
                {
                    didTheBeeGoOut = true;
                    return matrix;
                }

                return matrix;
            }

            static char[,] MovingLeft(char[,] matrix, int rowPossition, int collPossition, int collectedFlowers, bool didTheBeeGoOut)
            {
                matrix[rowPossition, collPossition] = '.';
                if (collPossition > 0)
                {
                    collPossition--;
                    if (matrix[rowPossition, collPossition] == '.')
                    {
                        matrix[rowPossition, collPossition] = 'B';
                    }
                    else if (matrix[rowPossition, collPossition] == 'f')
                    {
                        matrix[rowPossition, collPossition] = 'B';
                        collectedFlowers++;
                    }
                    else if (matrix[rowPossition, collPossition] == 'O')
                    {
                        matrix[rowPossition, collPossition] = 'B';
                        MovingLeft(matrix, rowPossition, collPossition, collectedFlowers, didTheBeeGoOut);
                    }

                }
                else
                {
                    didTheBeeGoOut = true;
                    return matrix;
                }

                return matrix;
            }

            static char[,] MovingRight(char[,] matrix, int rowPossition, int collPossition, int collectedFlowers, bool didTheBeeGoOut)
            {
                matrix[rowPossition, collPossition] = '.';
                if (collPossition < matrix.GetLength(0) - 1)
                {
                    collPossition++;
                    if (matrix[rowPossition, collPossition] == '.')
                    {
                        matrix[rowPossition, collPossition] = 'B';
                    }
                    else if (matrix[rowPossition, collPossition] == 'f')
                    {
                        matrix[rowPossition, collPossition] = 'B';
                        collectedFlowers++;
                    }
                    else if (matrix[rowPossition, collPossition] == 'O')
                    {
                        matrix[rowPossition, collPossition] = 'B';
                        MovingRight(matrix, rowPossition, collPossition, collectedFlowers, didTheBeeGoOut);
                    }

                }
                else
                {
                    didTheBeeGoOut = true;
                    return matrix;
                }

                return matrix;
            }
        }
    }
}
