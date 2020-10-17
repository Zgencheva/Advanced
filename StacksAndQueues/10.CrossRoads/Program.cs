using System;
using System.Collections.Generic;

namespace _10.CrossRoads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            int currentGreen = greenLight;
            int currentFreeWind = freeWindow;
            Queue<string> carQueue = new Queue<string>();
            bool isAllSafe = true;
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }
                else if (command == "green")
                {
                    currentGreen = greenLight;
                    currentFreeWind = freeWindow;
                }
                else
                {
                    int carLength = command.Length;
                    if (currentGreen == 0)
                    {
                        continue;
                    }
                    else if (currentGreen >= carLength)
                    {
                        currentGreen -= carLength;
                        carQueue.Enqueue(command);
                    }
                    else
                    {
                        int lengthInWindow = Math.Abs(currentGreen - carLength);
                        currentGreen = 0;
                        if (currentFreeWind >= lengthInWindow)
                        {
                            carQueue.Enqueue(command);
                        }
                        else
                        {
                            int stuck = carLength - (lengthInWindow - currentFreeWind); //4
                            isAllSafe = false;
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"Hummer was hit at {command[stuck]}.");
                            break;

                        }
                    }

                }
            }
            if (isAllSafe)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{carQueue.Count} total cars passed the crossroads.");
            }
        }
    }
}
