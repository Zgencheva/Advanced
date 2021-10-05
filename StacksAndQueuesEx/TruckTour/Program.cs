using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int[]> pumps = new Queue<int[]>();
     

            bool isFinished = true;
            int amountOfPetrol = 0;
            int distance = 0;
            //creating the pertol pumps
            for (int i = 0; i < n; i++)
            {
                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                pumps.Enqueue(nums);
                

            }
            //Queue<int[]> currentTour = pumps;
            for (int t = 0; t < n; t++)
            {
                for (int r = 0; r < n; r++)
                {
                    int[] current = pumps.Dequeue();
                    amountOfPetrol += current[0];
                    distance += current[1];
                    if (amountOfPetrol < distance)
                    {
                        isFinished = false;
                        
                        
                    }
                    pumps.Enqueue(current);
                }
                if (isFinished)
                {
                    //isFinished = true;
                    Console.WriteLine($"{t}");
                    break;
                }
                else
                {
                    amountOfPetrol = 0;
                    distance = 0;
                    int[] switched = pumps.Dequeue();
                    pumps.Enqueue(switched);
                    isFinished = true;
                    
                }


            }
        }
    }
}
