using System;
using System.Collections.Generic;
using System.Linq;

namespace Flower_Wreaths
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] liliesArr = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] rosesArr = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> lilies = new Stack<int>(liliesArr);
            Queue<int> roses = new Queue<int>(rosesArr);

            int wreaths = 0;
            int stored = 0;

            while (true)
            {
                if (lilies.Count == 0 || roses.Count == 0)
                {
                    break;
                }
                
                int currentNum = lilies.Peek() + roses.Peek();

                if (currentNum == 15)
                {
                    wreaths++;
                    lilies.Pop();
                    roses.Dequeue();
                }
                else if (currentNum < 15)
                {
                    stored += currentNum;
                    lilies.Pop();
                    roses.Dequeue();
                }
                else
                {
                    lilies.Push(lilies.Pop() - 2);
                }

            }

            wreaths += stored / 15;
            if (wreaths >=5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreaths} wreaths more!");
            }
        }
    }
}
