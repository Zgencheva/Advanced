using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace exam20Feb2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int wavesNum = int.Parse(Console.ReadLine());
            int[] platesArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            bool isDestroyed = false;
            Queue<int> plates = new Queue<int>(platesArr);
            Stack<int> waves = new Stack<int>();
          
            for (int i = 1; i <= wavesNum; i++)
            {
                
                
                int[] currentWaveArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
                if (i % 3 == 0)
                {
                    plates.Enqueue(int.Parse(Console.ReadLine()));
                }
                //Stack<int> waves = new Stack<int>(currentWaveArr);
                waves = new Stack<int>(currentWaveArr);
                
                while (plates.Count > 0 && waves.Count > 0)
                {
                    int currentPlate = plates.Dequeue();
                    int currentOrc = waves.Pop();

                    if (currentPlate > currentOrc)
                    {
                        currentPlate -= currentOrc;
                        //waves.Pop();
                        plates.Enqueue(currentPlate);
                        for (int s = 0; s < plates.Count - 1; s++)
                        {
                            plates.Enqueue(plates.Dequeue());
                        }
                        
                    }
                    else if(currentOrc > currentPlate)
                    {
                        currentOrc -= currentPlate;
                        
                        waves.Push(currentOrc);
                        
                        
                    }
                  
                }
               
                if (plates.Count == 0)
                {
                  
                    isDestroyed = true;
                    break;
                }
               

                

            }
            if (isDestroyed)
            {
                isDestroyed = true;
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.Write($"Orcs left: {string.Join(", ", waves)}");

            }
            else
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.Write($"Plates left: {string.Join(", ", plates)}");
            }
            
        }
    }
}
