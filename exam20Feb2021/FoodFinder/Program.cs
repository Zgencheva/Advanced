using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FoodFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] queueArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
            char[] stackArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
            Queue<char> vowels = new Queue<char>(queueArray);
            Stack<char> consonants = new Stack<char>(stackArray);
            HashSet<char> charCollection = new HashSet<char>();
            List<char> charsFound = new List<char>();
            List<string> result = new List<string>();
            string[] words = new string[] 
            {
                	"pear", "flour", "pork","olive"
            };
            
            for (int i = 0; i < 4; i++)
            {
                for (int r = 0; r < words[i].Length; r++)
                {
                    charCollection.Add(words[i][r]);
                }
            }
            
            while (consonants.Count > 0)
            {
                char currentVowel = vowels.Dequeue();
                char currentConsonant = consonants.Pop();
                if (charCollection.Contains(currentVowel))
                {
                    charsFound.Add(currentVowel);
                }
                if (charCollection.Contains(currentConsonant))
                {
                    charsFound.Add(currentConsonant);
                }
                vowels.Enqueue(currentVowel);
            }
            
            foreach (var item in words)
            {
                bool itemFound = true;
                for (int i = 0; i < item.Length; i++)
                {
                    //char currentChar = item[i];
                    if (!charsFound.Contains(item[i]))
                    {
                        itemFound = false;
                    }
                }
                if (itemFound)
                {
                    result.Add(item);
                }
            }

            Console.WriteLine($"Words found: {result.Count}");
            Console.WriteLine(string.Join("\n", result));
        }
    }
}
