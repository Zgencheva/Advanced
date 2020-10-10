﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> output = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                output.Push(input[i]);
            }
            while (output.Count > 0)
            {
                Console.Write(output.Pop());
            }
        }
    }
}
