using System;

namespace PawnWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] chessboard = ReadMatrix(8, 8);
            string[,] readchessmatr = ReadMatrixChess(8, 8);
            PrintMatrix(readchessmatr);
            int whiteRowPossition = 0;
            int whiteColPossition = 0;
            int blackColPossition = 0;
            int blackRowPossition = 0;
            bool whiteGetQueen = false;
            bool blackGetQueen = false;
            bool whiteDies = false;
            bool blackDies = false;
            int rowDeathPossition = 0;
            int colDeathPossition = 0;

            for (int row = 0; row < chessboard.GetLength(0); row++)
            {

                for (int col = 0; col < chessboard.GetLength(1); col++)
                {

                    if (chessboard[row, col] == "w")
                    {
                        whiteRowPossition = row;
                        whiteColPossition = col;
                    }
                    if (chessboard[row, col] == "b")
                    {
                        blackRowPossition = row;
                        blackColPossition = col;
                    }

                }
     

            }
            //if (Math.Abs(whiteColPossition - blackColPossition) > 1)
            //{

            //}
            for (int i = 1; i < 9; i++)
            {
                if (i % 2 !=0)
                {
                    if (whiteRowPossition > 0)
                    {
                        chessboard[whiteRowPossition, whiteColPossition] = "-";
                        whiteRowPossition--;
                        chessboard[whiteRowPossition, whiteColPossition] = "w";
                        if (whiteRowPossition >0)
                        {
                            if (whiteColPossition >0)
                            {
                                //move right
                                
                                int currentColPossition = whiteColPossition;
                                currentColPossition--;
                                if (chessboard[whiteRowPossition, currentColPossition] == "b")
                                {
                                    blackDies = true;
                                    Console.WriteLine($"Game over! White capture on {readchessmatr[whiteRowPossition, currentColPossition]}.");
                                    rowDeathPossition = whiteRowPossition;
                                    colDeathPossition = currentColPossition;
                                    chessboard[whiteRowPossition, whiteColPossition] = "-";
                                    chessboard[whiteRowPossition, currentColPossition] = "w";
                                    break;
                                }
                                

                            }
                            if (whiteColPossition < 7)
                            {
                                int currentColPossition = whiteColPossition;
                                currentColPossition++;
                                if (chessboard[whiteRowPossition, currentColPossition] == "b")
                                {
                                    blackDies = true;
                                    
                                    Console.WriteLine($"Game over! White capture on {readchessmatr[whiteColPossition, currentColPossition]}.");
                                    rowDeathPossition = whiteRowPossition;
                                    colDeathPossition = currentColPossition;
                                    chessboard[whiteRowPossition, whiteColPossition] = "-";
                                    chessboard[whiteRowPossition, currentColPossition] = "w";
                                    break;
                                }
                            }
                        }
                    }
                    else if (whiteRowPossition == 0)
                    {
                        whiteGetQueen = true;
                        chessboard[whiteRowPossition, whiteColPossition] = "w";
                        break;
                    }
                }
                else
                {
                    if (blackColPossition < 7)
                    {
                        chessboard[blackRowPossition, blackColPossition] = "-";
                        blackRowPossition++;
                        chessboard[blackRowPossition, blackColPossition] = "b";
                        if (blackRowPossition > 7)
                        {
                            if (blackColPossition< 7)
                            {
                                //move right

                                int currentColPossition = blackColPossition;
                                currentColPossition--;
                                if (chessboard[blackRowPossition, currentColPossition] == "w")
                                {
                                    whiteDies = true;
                                    
                                    rowDeathPossition = blackRowPossition;
                                    colDeathPossition = currentColPossition;
                                    Console.WriteLine($"Game over! White capture on {readchessmatr[rowDeathPossition, currentColPossition]}.");
                                    chessboard[blackRowPossition, blackColPossition] = "-";
                                    chessboard[whiteRowPossition, currentColPossition] = "b";
                                    break;
                                }


                            }
                            if (blackColPossition < 7)
                            {
                                int currentColPossition = blackColPossition;
                                currentColPossition++;
                                if (chessboard[blackRowPossition, currentColPossition] == "w")
                                {
                                    whiteDies = true;
                                    
                                    rowDeathPossition = blackRowPossition;
                                    colDeathPossition = currentColPossition;
                                    Console.WriteLine($"Game over! White capture on {readchessmatr[rowDeathPossition, currentColPossition]}.");
                                    chessboard[blackRowPossition, blackColPossition] = "-";
                                    chessboard[whiteRowPossition, currentColPossition] = "b";
                                    break;
                                }
                            }
                        }
                    }
                    else if (blackRowPossition == 0)
                    {
                        blackGetQueen = true;
                        chessboard[whiteRowPossition, whiteColPossition] = "b";
                        break;
                    }
                }
            }

            if (whiteGetQueen)
            {
                Console.WriteLine($"Game over! White pawn is promoted to a queen at {readchessmatr[whiteRowPossition--, whiteColPossition]}.");

            }
            else if(blackGetQueen)
            {
                Console.WriteLine($"Game over! White pawn is promoted to a queen at {readchessmatr[blackRowPossition++, blackColPossition]}.");
            }
           
            



        }

        static string[,] ReadMatrix(int rows, int cols)
        {
            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    string currentChar = rowData[col].ToString();
                    matrix[row, col] = currentChar;

                }
            }

            return matrix;
        }

        static void PrintMatrix(string[,] matrix)
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

        static string[,] ReadMatrixChess(int rows, int cols)
        {
            string[,] matrix = new string[rows, cols];
            int currentNum = 8;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                
                char currentChar = 'a';
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    
                    string currentString = currentChar.ToString();
                    matrix[row, col] = string.Concat(currentString, currentNum.ToString());
                    if (currentChar == 'w')
                    {

                    }
                    currentChar++;
                }
                currentNum--;
            }

            return matrix;
        }


    }
}





