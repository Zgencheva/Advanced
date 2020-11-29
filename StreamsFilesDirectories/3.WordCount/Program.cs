using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new SortedDictionary<string, int>();
            using (var reader1 = new StreamReader("../../../Words.txt"))
            {
                string inputWords = reader1.ReadToEnd();
                string[] words = inputWords.Split();

                using var writer = new StreamWriter("../../../Output.txt");

                using (var reader = new StreamReader("../../../Text.txt"))
                {
                    string currentSentence = reader.ReadLine();

                    while (currentSentence != null)
                    {
                        foreach (var word in words)
                        {
                            if (currentSentence.ToLower().Contains(word))
                            {

                                if (!dictionary.ContainsKey(word))
                                {
                                    dictionary.Add(word, 0);
                                    dictionary[word]++;
                                }
                                else
                                {
                                    dictionary[word]++;
                                }
                            }
                        }

                        currentSentence = reader.ReadLine();
                    }
                }
            
            

                foreach (var word in dictionary.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}