using System;
using System.Collections.Generic;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    indexes.Push(i);
                }
                if (input[i] == ')')
                {
                    int startIndex = indexes.Pop();
                    int endIndex = i;
                    Console.WriteLine(input.Substring(startIndex, endIndex - startIndex + 1));
                }
            }
        }
    }
}
