using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebration
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] guestsArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] platesArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> guests = new Queue<int>(guestsArray);
            Stack<int> plates = new Stack<int>(platesArray);
            int wastedFood = 0;
            while (guests.Count > 0 && plates.Count > 0)
            {
                int currentGuest = guests.Peek();
                int currentPlate = plates.Pop();
                if (currentPlate > currentGuest)
                {
                    wastedFood += currentPlate - currentGuest;
                    guests.Dequeue();
                }
                else if (currentGuest == currentPlate)
                {
                    guests.Dequeue();
                }
                else
                {
                    currentGuest -= currentPlate;
                    while (currentGuest > 0 && plates.Count > 0)
                    {
                        int currentPl = plates.Pop();
                        currentGuest -= currentPl;
                        if (currentGuest > 0)
                        {
                            Queue<int> temp = new Queue<int>();
                            temp.Enqueue(currentGuest);
                            guests.Dequeue();
                            while (guests.Count > 0)
                            {
                                temp.Enqueue(guests.Dequeue());
                            }
                            guests = temp;
                        }
                        else
                        {
                            guests.Dequeue();
                        }
                        
                    }
                   wastedFood += -(currentGuest);
                }
            }

            if (plates.Count > 0)
            {
                Console.WriteLine($"Plates: {string.Join(" ", plates)}");
            }
            else
            {
                Console.WriteLine($"Guests: {string.Join(" ", guests)}");
            }
            Console.WriteLine($"Wasted grams of food: {wastedFood}");

        }
    }
}
