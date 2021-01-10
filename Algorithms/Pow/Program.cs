using System;
using System.Linq.Expressions;

namespace Pow
{
    class Program
    {
        static void Main(string[] args)
        {
            //count x ^n
            
            int x = int.Parse(Console.ReadLine()); //number
            int n = int.Parse(Console.ReadLine()); // pow
            //iteractive method:

            //int result = 1;
            //for (int i = 0; i < x; i++)
            //{
            //    result *= n;
            //}

            //Console.WriteLine(result);

            //recursive method:
            Console.WriteLine(Pow(x, n));
            
            
        }

        private static int Pow(int x, int n)
        {   
            if (n == 1)
            {
                return x;
            }
            Console.WriteLine("Before recursion");
            int current = x * Pow(x, n - 1);
            Console.WriteLine("After recursion");

            return current;
        }
    }
}
