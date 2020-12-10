using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();
            Func<string, int> namesInAscii = name => name.Select(c => (int)c).Sum();
            //secondWay
            //{
            //    int sum = 0;
            //    for (int i = 0; i < name.Length; i++)
            //    {
            //        sum += name[0];
            //    }
            //    return sum;
            //};

            Func<List<string>, int, Func<string, int>, string> res = (names, n, namesInAscii) =>
            {
                string name = null;
                for (int i = 0; i < names.Count; i++)
                {
                    if (namesInAscii(names[i]) >= n)
                    {
                        name = names[i];
                        break;
                    }
                }
                return name;

            };

            Console.WriteLine(res(names, n, namesInAscii));
        }
    }
}
