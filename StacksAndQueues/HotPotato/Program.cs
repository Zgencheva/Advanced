using System;
using System.Collections.Generic;
using System.Linq;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine().Split().ToArray();
            Queue<string> queue = new Queue<string>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < children.Length; i++)
            {
                queue.Enqueue(children[i]);
            }

            while (queue.Count > 1)
            {
                for (int i = 1; i < count; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }

                Console.WriteLine($"Removed {queue.Dequeue()}");
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
