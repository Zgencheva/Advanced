using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9.SimpleTestEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = string.Empty;
            StringBuilder sb = new StringBuilder(input);
            Stack<string> stack = new Stack<string>();
            stack.Push(input);
            for (int i = 0; i < n; i++)
            {
                string[] currentInput = Console.ReadLine().Split().ToArray();
                int currentIn = int.Parse(currentInput[0]);
                if (currentIn == 1)
                {
                    sb.Append(currentInput[1]);
                    stack.Push(sb.ToString());
                }
                else if (currentIn == 2)
                {
                    int currentLength = int.Parse(currentInput[1]);
                    if (currentLength <= sb.Length)
                    {
                        sb.Remove(sb.Length - currentLength, currentLength);
                        stack.Push(sb.ToString());
                    }

                }
                else if (currentIn == 3)
                {
                    string currentWord = sb.ToString();
                    int index = int.Parse(currentInput[1]);

                    Console.WriteLine(currentWord[index - 1]);

                }
                else if (currentIn == 4)
                {

                    stack.Pop();
                    string currentWord = stack.Peek();
                    sb.Clear();
                    sb.Append(currentWord);
                    

                }
            }
        }
    }
}
