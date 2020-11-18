using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _5.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] measures = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int row = measures[0];
            //int col = measures[1];
            char[,] matrix = new char[measures[0], measures[1]];
            bool toTheRight = true;
            bool toTheLeft = false;
            string snake = Console.ReadLine();
            int currentChar = 0;
            
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                if (toTheRight)
                {
                    for (int cols = 0; cols < matrix.GetLength(1); cols++)
                    {
                        
                        matrix[rows, cols] = snake[currentChar];
                        currentChar++;
                        if (currentChar == snake.Length)
                        {
                            currentChar = 0;
                        }

                    }
                    toTheRight = false;
                    toTheLeft = true;
                }
                else if (toTheLeft)
                {
                    for (int colsLeft = matrix.GetLength(1) - 1; colsLeft >= 0; colsLeft--)
                    {
                        
                        matrix[rows, colsLeft] = snake[currentChar];
                        currentChar++;
                        if (currentChar == snake.Length)
                        {
                            currentChar = 0;
                        }
                    }
                    toTheRight = true;
                    toTheLeft = false;
                }
            }
            GetMatrix(matrix);
            
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
