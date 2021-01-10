using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Loop(3);
        }

        private static void Loop(int n)
        {
            
            //the end
            if (n==0)
            {
                return;
            }
            //printing
            Console.WriteLine("in the loop");
            Loop(n - 1);
        }
    }
}
