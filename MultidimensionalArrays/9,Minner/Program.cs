using System;
using System.Linq;

namespace _9_Minner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split().ToArray();
            char[,] matrix = ReadMatrix(n,n);
            int coals = GetTotalCoals(matrix);
            bool isTheGameEnded = false;
            int rowPossition = 0;
            int collPossition = 0;
            //Getting the start possition
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == 's')
                    {
                        rowPossition = row;
                        collPossition = col;
                    }
                    
                }
            }
            for (int i = 0; i < commands.Length; i++)
            {
                string currentCommand = commands[i];
                if (currentCommand == "right")
                {
                    if (collPossition < n - 1)
                    {
                        collPossition++;
                        if (matrix[rowPossition, collPossition] == 'c')
                        {
                            coals--;
                            matrix[rowPossition, collPossition] = '*';
                        }
                        else if (matrix[rowPossition, collPossition] == 'e')
                        {
                            Console.WriteLine($"Game over! ({rowPossition}, {collPossition})");
                            isTheGameEnded = true;
                            break;
                        }
                    }
                }
                else if (currentCommand == "left")
                {
                    if (collPossition > 0)
                    {
                        collPossition--;
                        if (matrix[rowPossition, collPossition] == 'c')
                        {
                            coals--;
                            matrix[rowPossition, collPossition] = '*';
                        }
                        else if (matrix[rowPossition, collPossition] == 'e')
                        {
                            Console.WriteLine($"Game over! ({rowPossition}, {collPossition})");
                            isTheGameEnded = true;
                            break;
                        }
                    }
                }
                else if (currentCommand == "down")
                {
                    if (rowPossition < n - 1)
                    {
                        rowPossition++;
                        if (matrix[rowPossition, collPossition] == 'c')
                        {
                            coals--;
                            matrix[rowPossition, collPossition] = '*';
                        }
                        else if (matrix[rowPossition, collPossition] == 'e')
                        {
                            Console.WriteLine($"Game over! ({rowPossition}, {collPossition})");
                            isTheGameEnded = true;
                            break;
                        }
                    }
                }
                else if (currentCommand == "up")
                {
                    if (rowPossition > 0)
                    {
                        rowPossition--;
                        if (matrix[rowPossition, collPossition] == 'c')
                        {
                            coals--;
                            matrix[rowPossition, collPossition] = '*';
                        }
                        else if (matrix[rowPossition, collPossition] == 'e')
                        {
                            Console.WriteLine($"Game over! ({rowPossition}, {collPossition})");
                            isTheGameEnded = true;
                            break;
                        }

                    }
                }
                if (coals == 0)
                {
                    
                    Console.WriteLine($"You collected all coals! ({rowPossition}, {collPossition})");
                    break;
                }
                
            }

            if (coals > 0 && !isTheGameEnded)
            {
                Console.WriteLine($"{coals} coals left. ({rowPossition}, {collPossition})");
            }

        }

        static char[,] ReadMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine()
                .Split()
                .Select(char.Parse)
                .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            return matrix;
        }

        static int GetTotalCoals(char[,] matrix)
        {
            
            int totalCoals = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'c')
                    {
                        totalCoals++;
                    }
                }
            }

            return totalCoals;
        }


    }
}
