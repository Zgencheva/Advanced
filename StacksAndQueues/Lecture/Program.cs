using System;
using System.Collections.Generic;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            string book = Console.ReadLine();
            while (book != "end")
            {
                stack.Push(book);
                book = Console.ReadLine();
            }
            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Pop());

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
