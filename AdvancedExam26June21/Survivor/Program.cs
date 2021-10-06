using System;
using System.Linq;

namespace Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            //jagged array
            int n = int.Parse(Console.ReadLine());
            int collectTokens = 0;
            int opponentTokens = 0;
            char[][] beach = new char[n][];
            for (int i = 0; i < n; i++)
            {
                
                beach[i] = Console.ReadLine().Split().Select(char.Parse).ToArray();
            }

            while (true)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                string command = cmd[0];
                if (command == "Gong")
                {
                    break;
                }
                else if (command == "Find")
                {
                    int row = int.Parse(cmd[1]);
                    int col = int.Parse(cmd[2]);
                    if (IsValid(row, col, beach))
                    {
                        char symbol = beach[row][col];
                        if (symbol == 'T')
                        {
                            collectTokens++;
                            beach[row][col] = '-';
                        }
                    }
                    //else
                    //{
                    //    continue;
                    //}
                }
                else if (command == "Opponent")
                {
                    int row = int.Parse(cmd[1]);
                    int col = int.Parse(cmd[2]);
                    string direction = cmd[3];
                    if (IsValid(row, col, beach))
                    {
                        char symbol = beach[row][col];
                        if (symbol == 'T')
                        {
                            opponentTokens++;
                            beach[row][col] = '-';
                        }
                    }
                    else
                    {
                        continue;
                    }
                    if (direction == "up")
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            row--;
                            if (IsValid(row, col, beach))
                            {
                                char symbol = beach[row][col];
                                if (symbol == 'T')
                                {
                                    opponentTokens++;
                                    beach[row][col] = '-';
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    else if (direction == "down")
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            row++;
                            if (IsValid(row, col, beach))
                            {
                                char symbol = beach[row][col];
                                if (symbol == 'T')
                                {
                                    opponentTokens++;
                                    beach[row][col] = '-';
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    else if (direction == "left")
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            col--;
                            if (IsValid(row, col, beach))
                            {
                                char symbol = beach[row][col];
                                if (symbol == 'T')
                                {
                                    opponentTokens++;
                                    beach[row][col] = '-';
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    else if (direction == "right")
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            col++;
                            if (IsValid(row, col, beach))
                            {
                                char symbol = beach[row][col];
                                if (symbol == 'T')
                                {
                                    opponentTokens++;
                                    beach[row][col] = '-';
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }


            //output
            foreach (char[] row in beach)
            {
                Console.WriteLine(string.Join(" ", row));
            }

            Console.WriteLine($"Collected tokens: {collectTokens}");
            Console.WriteLine($"Opponent's tokens: {opponentTokens}");

            static bool IsValid(int row, int col, char[][] matrix)
            {
                if (row < 0 || row >= matrix.Length)
                {
                    return false;
                }
                if (col >= matrix[row].Length || col < 0)
                {
                    return false;
                }
                return true;
            }


        }
    }
    
}
