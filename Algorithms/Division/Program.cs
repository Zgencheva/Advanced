using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine()); //the number we will divide
            int n = int.Parse(Console.ReadLine()); // the times we will divide
            int d = int.Parse(Console.ReadLine()); // the division number

            Console.WriteLine(Division(x, n, d));
        }

        static int Division(int x, int n, int d)
        {
            if (n ==0)
            {
                return x;
            }
            int division = Division(x, n-1, d);
            return division / d;
        }
    }
}
