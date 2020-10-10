using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().Reverse().ToArray();
            Stack<string> calc = new Stack<string>(input);
            
            int sum = 0;
            while (calc.Count > 1)
            {
                int first = int.Parse(calc.Pop());                
                string sign = calc.Pop();
                int second = int.Parse(calc.Pop());
                if (sign == "+")
                {
                    calc.Push((first + second).ToString());
                }
                else
                {
                    calc.Push((first - second).ToString());
                }
               
            }
            Console.WriteLine(calc.Pop());
        }
    }
}
