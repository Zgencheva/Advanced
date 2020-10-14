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
            bool indexFound = false;
            for (int i = 0; i < stops; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                path.Enqueue(input);
                initialStops.Enqueue(input);
            }

            while (true)
            {
                int fuelTotal = 0;
                int distanceTotal = 0;
                int currentIndex = 0;
                
                while (path.Count > 0)
                {
                    int[] currentStop = path.Dequeue();
                    path.Enqueue(currentStop);
                    fuelTotal += currentStop[0];
                    int distance = currentStop[1];
                    if (fuelTotal < distance)
                    {
                        
                        //path = initialStops;
                        index++;
                        break;
                    }
                    else
                    {
                        currentIndex++;
                        
                        if (currentIndex == stops)
                        {
                            Console.WriteLine($"{index}");
                            indexFound = true;
                            break;
                        }
                        fuelTotal -= distance;
                        continue;
                    }
                    
                }
                if (indexFound)
                {
                    break;
                }
                else
                {
                    initialStops.Enqueue(initialStops.Dequeue());
                    path.Clear();
                    Queue<int[]> path2 = new Queue<int[]>(initialStops);
                    path = path2;
                                        
                }
            }

        }
    }
}
