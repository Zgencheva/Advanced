using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int stops = int.Parse(Console.ReadLine());
            Queue<int[]> path = new Queue<int[]>();
            Queue<int[]> initialStops = new Queue<int[]>();
            int index = 0;
            for (int i = 0; i < stops; i++)
            {
                path.Enqueue(Console.ReadLine().Split().Select(int.Parse).ToArray());
                initialStops.Enqueue(Console.ReadLine().Split().Select(int.Parse).ToArray());
            }

            while (true)
            {
                int fuelTotal = 0;
                int distanceTotal = 0;
                while (path.Count > 0)
                {
                    int[] currentStop = path.Dequeue();
                    int fuel = +currentStop[0];
                    int distance = currentStop[1];
                    if (fuel < distance)
                    {
                        initialStops.Enqueue(currentStop);
                        index++;
                        break;
                    }
                }
            }

        }
    }
}
