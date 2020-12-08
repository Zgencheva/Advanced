using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split().Select(double.Parse).ToList();

            Func<List<double>, List<double>> addFunc = (input) =>
            {
                List<double> currentList = new List<double>();
                currentList = input.Select(x => x + 1).ToList();
                return currentList;
            };

            Func<List<double>, List<double>> substractFunc = (input) =>
            {
                List<double> currentList = new List<double>();
                currentList = input.Select(x => x - 1).ToList();
                return currentList;
            };
            Func<List<double>, List<double>> multiplyFunc = (input) =>
            {
                List<double> currentList = new List<double>();
                currentList = input.Select(x => x * 2).ToList();
                return currentList;
            };
            Action<List<double>> print = x =>  Console.WriteLine(string.Join(" ", x));
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                else if (command == "add")
                {
                    input = addFunc(input);
                }
                else if (command == "multiply")
                {
                    input = multiplyFunc(input);
                }
                else if (command == "subtract")
                {
                    input = substractFunc(input);
                }
                else if (command == "print")
                {
                    print(input);
                }
            }
          
        }


    }
}
