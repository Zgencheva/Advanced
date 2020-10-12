using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queuesOfOrders = new Queue<int>(orders);
            Console.WriteLine(queuesOfOrders.Max());
            bool areAllOrdersComplete = true;
            while (queuesOfOrders.Count > 0)
            {
                int currentOrder = queuesOfOrders.Peek();
                if (quantityOfFood - currentOrder < 0 )
                {
                    areAllOrdersComplete = false;
                    
                    break;
                }
                quantityOfFood -= currentOrder;
                queuesOfOrders.Dequeue();
            }
            if (areAllOrdersComplete)
            {
                Console.WriteLine($"Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(' ', queuesOfOrders)}");
            }
        }
    }
}
