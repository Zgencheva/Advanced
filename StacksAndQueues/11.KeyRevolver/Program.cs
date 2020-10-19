using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int sizeOfGunBArrel = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int valueOfIntelligence = int.Parse(Console.ReadLine());

            Stack<int> bulletsStack = new Stack<int>(bullets);
            Queue<int> locksQueue = new Queue<int>(locks);
            int bulletCounter = 0;
            int counterOfSize = 0;
            while (bulletsStack.Count >0)
            {
                if (counterOfSize == sizeOfGunBArrel)
                {
                    Console.WriteLine("Reloading!");
                    counterOfSize = 0;


                }
                if (locksQueue.Count == 0)
                {
                    
                    break;
                }
                
                int currentBullet = bulletsStack.Pop();
                counterOfSize++;             
                bulletCounter++;
                int currentLock = locksQueue.Peek();
                if (currentBullet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                    locksQueue.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                
            }
            if (locksQueue.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
            }
            else
            {
                Console.WriteLine($"{bulletsStack.Count} bullets left. Earned ${valueOfIntelligence - (bulletCounter * bulletPrice)}");
            }
            
        }
    }
}
