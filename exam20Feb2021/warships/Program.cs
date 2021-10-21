using System;
using System.Linq;

namespace warships
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int firstPlayerShips = 0;
            int secondPlayerShips = 0;
            bool firstPlayerWins = false;
            bool seconPlayerWins = false;
            string[] coordinates = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).ToArray();
            //filling the matrix
            char[,] array = new char[matrixSize, matrixSize];
            for (int row = 0; row < matrixSize; row++)
            {
                char[] fields = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < matrixSize; col++)
                {
                    char currentField = fields[col];
                    array[row, col] = currentField;
                    if (currentField == '<')
                    {
                        firstPlayerShips++;
                    }
                    else if (currentField == '>')
                    {
                        secondPlayerShips++;
                    }
                }


            }
            int totalShips = firstPlayerShips + secondPlayerShips;
            //printMatrix(array);
            for (int i = 0; i < coordinates.Length; i++)
            {
                string[] splittedCommands = coordinates[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(splittedCommands[0]);
                int col = int.Parse(splittedCommands[1]);
                if (!isValidCoordinate(array, row, col))
                {
                    continue;
                }

                if (array[row, col] == '<')
                {

                    firstPlayerShips--;
                    if (firstPlayerShips == 0)
                    {
                        seconPlayerWins = true;
                        break;
                    }
                }
                else if (array[row, col] == '>')
                {

                    secondPlayerShips--;
                    if (secondPlayerShips == 0)
                    {
                        firstPlayerWins = true;
                        break;
                    }
                }
                else if (array[row, col] == '#')
                {

                    //MoveUp
                    if (row > 0)
                    {
                        row--;
                        if (array[row, col] == '<')
                        {

                            firstPlayerShips--;
                            if (firstPlayerShips == 0)
                            {
                                seconPlayerWins = true;
                                break;
                            }
                        }
                        else if (array[row, col] == '>')
                        {

                            secondPlayerShips--;
                            if (secondPlayerShips == 0)
                            {
                                firstPlayerWins = true;
                                break;
                            }
                        }

                        //moveUpRight
                        if (col < matrixSize - 1)
                        {
                            col++;
                            if (array[row, col] == '<')
                            {

                                firstPlayerShips--;
                                if (firstPlayerShips == 0)
                                {
                                    seconPlayerWins = true;
                                    break;
                                }
                            }
                            else if (array[row, col] == '>')
                            {

                                secondPlayerShips--;
                                if (secondPlayerShips == 0)
                                {
                                    firstPlayerWins = true;
                                    break;
                                }
                            }
                            col--;
                        }
                        //moveUpLeft
                        if (col > 0)
                        {
                            col--;
                            if (array[row, col] == '<')
                            {

                                firstPlayerShips--;
                                if (firstPlayerShips == 0)
                                {
                                    seconPlayerWins = true;
                                    break;
                                }
                            }
                            else if (array[row, col] == '>')
                            {

                                secondPlayerShips--;
                                if (secondPlayerShips == 0)
                                {
                                    firstPlayerWins = true;
                                    break;
                                }
                            }
                            col++;
                        }
                        row++;

                    }
                    //canGoDown
                    if (row < matrixSize - 1)
                    {
                        row++;
                        if (array[row, col] == '<')
                        {

                            firstPlayerShips--;
                            if (firstPlayerShips == 0)
                            {
                                seconPlayerWins = true;
                                break;
                            }
                        }
                        else if (array[row, col] == '>')
                        {

                            secondPlayerShips--;
                            if (secondPlayerShips == 0)
                            {
                                firstPlayerWins = true;
                                break;
                            }
                        }

                        //DownRight
                        if (col < matrixSize - 1)
                        {
                            col++;
                            if (array[row, col] == '<')
                            {

                                firstPlayerShips--;
                                if (firstPlayerShips == 0)
                                {
                                    seconPlayerWins = true;
                                    break;
                                }
                            }
                            else if (array[row, col] == '>')
                            {

                                secondPlayerShips--;
                                if (secondPlayerShips == 0)
                                {
                                    firstPlayerWins = true;
                                    break;
                                }
                            }
                            col--;
                        }
                        //DownLeft
                        if (col > 0)
                        {
                            col--;
                            if (array[row, col] == '<')
                            {

                                firstPlayerShips--;
                                if (firstPlayerShips == 0)
                                {
                                    seconPlayerWins = true;
                                    break;
                                }
                            }
                            else if (array[row, col] == '>')
                            {

                                secondPlayerShips--;
                                if (secondPlayerShips == 0)
                                {
                                    firstPlayerWins = true;
                                    break;
                                }
                            }
                            col++;
                        }
                        row--;
                    }
                    //CanGoLEft
                    if (col > 0)
                    {
                        col--;
                        if (array[row, col] == '<')
                        {

                            firstPlayerShips--;
                            if (firstPlayerShips == 0)
                            {
                                seconPlayerWins = true;
                                break;
                            }
                        }
                        else if (array[row, col] == '>')
                        {

                            secondPlayerShips--;
                            if (secondPlayerShips == 0)
                            {
                                firstPlayerWins = true;
                                break;
                            }
                        }

                        col++;
                    }
                    //canGoRight
                    if (col < matrixSize - 1)
                    {
                        col++;
                        if (array[row, col] == '<')
                        {

                            firstPlayerShips--;
                            if (firstPlayerShips == 0)
                            {
                                seconPlayerWins = true;
                                break;
                            }
                        }
                        else if (array[row, col] == '>')
                        {

                            secondPlayerShips--;
                            if (secondPlayerShips == 0)
                            {
                                firstPlayerWins = true;
                                break;
                            }
                        }

                        col--;
                    }

                }
                array[row, col] = 'X';

            }
            if (firstPlayerWins)
            {
                Console.WriteLine($"Player One has won the game! {totalShips - firstPlayerShips} ships have been sunk in the battle.");
            }
            else if (seconPlayerWins)
            {
                Console.WriteLine($"Player Two has won the game! {totalShips - secondPlayerShips} ships have been sunk in the battle.");
            }
            else
            {
                Console.WriteLine($"It's a draw! Player One has {firstPlayerShips} ships left. Player Two has {secondPlayerShips} ships left.");
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
