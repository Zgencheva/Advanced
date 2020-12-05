using System;
using System.IO;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> sumDelegate = SumNumbers;
            Func<int, int, int> multiplyDelegate = MultiplyNums;
            Calculate(5, 5, sumDelegate);
            Calculate(5, 5, multiplyDelegate);
            Calculate(5,5, (a, b) => a / b);
            Calculate(5,5, (a, b) => a);

        }

        static int SumNumbers(int a, int b)
        {
            Console.WriteLine("Suming nums:");
            return a + b;
        }

        static int MultiplyNums(int a, int b)
        {
            Console.WriteLine("Multiply nums:");
            return a * b;
        }

        static void Calculate(int a, int b, Func<int, int, int> operation)
        {
            using (StreamWriter writer = new StreamWriter("../../../result.txt"))
            {
                writer.WriteLine("Start calculating");
                writer.WriteLine(operation(a, b));
            }
        
        }
    }
}
