using System;
using System.Collections.Generic;

namespace _08.BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); //{[()]} ()()()()()() //()((()))[][][][(((())))]
            Stack<char> stack = new Stack<char>();
            bool areTheyEqual = true;
            if (input.Length % 2 != 0)
            {
                areTheyEqual = false;
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == '(' || input[i] == '[' || input[i] == '{')
                    {
                        stack.Push(input[i]);
                    }
                    else if (input[i] == ')' || input[i] == ']' || input[i] == '}')
                    {
                        if (stack.Count == 0)
                        {
                            areTheyEqual = false;
                            break;
                        }
                        char currentPart = stack.Pop();
                        if (currentPart == '(')
                        {
                            if (input[i] != ')')
                            {
                                areTheyEqual = false;
                                break;
                            }
                        }
                        else if (currentPart == '[')
                        {
                            if (input[i] != ']')
                            {
                                areTheyEqual = false;
                                break;
                            }
                        }
                        else if (currentPart == '{')
                        {
                            if (input[i] != '}')
                            {
                                areTheyEqual = false;
                                break;
                            }
                        }
                    }
                    
                }
            }
            if (stack.Count == 0 && areTheyEqual)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
