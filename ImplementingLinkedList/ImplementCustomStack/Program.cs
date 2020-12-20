using System;

namespace ImplementCustomStack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CustomStack newStack = new CustomStack();
            for (int i = 0; i <= 5; i++)
            {
                newStack.Push(i);
            }

            
        }
    }
}
