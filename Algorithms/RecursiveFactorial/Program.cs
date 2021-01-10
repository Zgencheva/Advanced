using System;

namespace RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FactorialResult(int.Parse(Console.ReadLine())));
        }

        static int FactorialResult(int n)
        {

            if (n == 1)
            {
                return 1;
            }
            //int current = n * FactorialResult(n-1);
            //return current;
            Console.WriteLine($"{n} = {n} * {n - 1}!");
            int nMinusOneFactorial = FactorialResult(n - 1);
            Console.WriteLine($"{n} = {n} * {nMinusOneFactorial}");
            return n * nMinusOneFactorial;
        }
    }
}
