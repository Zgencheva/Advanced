using System;
using System.Collections.Generic;
using System.IO;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            int counter = 0;
            while (true)
            {
                string car = Console.ReadLine();
                if (car == "end")
                {
                    break;
                }
                else if (car == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (queue.Count > 0)
                        {
                            counter++;
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                        }

                    }
                }
                else
                {
                    queue.Enqueue(car);
                }

            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
