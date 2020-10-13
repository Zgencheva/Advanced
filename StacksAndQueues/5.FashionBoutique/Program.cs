using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> clothes = new Stack<int>(input);
            int capacityOfARack = int.Parse(Console.ReadLine());
            int racks = 1;
            int sum = 0;
            while (clothes.Count > 0)
            {
                
                int currentClothes = clothes.Peek();
                if (sum + currentClothes <= capacityOfARack)
                {
                    sum += currentClothes;
                    clothes.Pop();
                }
                else if (sum + currentClothes > capacityOfARack)
                {
                    sum = 0;
                    racks++;
                }
            }
            Console.WriteLine(racks);
        }
    }
}
