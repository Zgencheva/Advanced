﻿using System;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 2];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = row + col;
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }   
        }
    }
}
