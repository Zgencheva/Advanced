using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ExamPreparation
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] queueNums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] stacknums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> firstBox = new Queue<int>();
            for (int i = 0; i < queueNums.Length; i++)
            {
                firstBox.Enqueue(queueNums[i]);
            }
            Stack<int> secondBox = new Stack<int>();
            for (int i = 0; i < stacknums.Length; i++)
            {
                secondBox.Push(stacknums[i]);
            }
            List<int> myCollection = new List<int>();
            while (true)
            {
                if (firstBox.Count == 0)
                {
                    Console.WriteLine("First lootbox is empty");
                    break;
                }
                if (secondBox.Count == 0)
                {
                    Console.WriteLine("Second lootbox is empty");
                    break;
                }
                int currentNum = firstBox.Peek() + secondBox.Peek();
                if (currentNum % 2 == 0)
                {
                    myCollection.Add(currentNum);
                    secondBox.Pop();
                    firstBox.Dequeue();
                }
                else
                {
                    firstBox.Enqueue(secondBox.Pop());
                }
            }

            int value = myCollection.Sum(x => x);
            if (value >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {value}");
            }

            else
            {
                Console.WriteLine($"Your loot was poor... Value: {value}");
            }

        }
    }
}
