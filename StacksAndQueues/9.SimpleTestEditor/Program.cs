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
                if (int.Parse(currentInput[0]) == 1)
                {
                    sb.Append(currentInput[1]);
                    stack.Push(sb.ToString());
                }
                else if (int.Parse(currentInput[0]) == 2)
                {
                    int currentLength = int.Parse(currentInput[1]);
                    if (currentLength <= sb.Length)
                    {
                        sb.Remove(sb.Length - currentLength, currentLength);
                        stack.Push(sb.ToString());
                    }

                }
                else if (int.Parse(currentInput[0]) == 3)
                {
                    string currentWord = sb.ToString();
                    int index = int.Parse(currentInput[1]);
                    if (0<= index && index <= currentWord.Length - 1)
                    {

                    Console.WriteLine(currentWord[index - 1]);
                    }
                }
                else if (int.Parse(currentInput[0]) == 4)
                {
                    if (stack.Count > 1)
                    {
                        stack.Pop();

                    }
                    if (stack.Count > 0)
                    {
                        string currentWord = stack.Pop();
                        sb.Clear();
                        sb.Append(currentWord);
                        stack.Push(sb.ToString());
                    }

                }
            }
        }
    }
}
