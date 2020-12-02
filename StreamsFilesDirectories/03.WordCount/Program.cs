using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordsToFind = File.ReadAllLines("../../../words.txt");
            string[] text = File.ReadAllLines("../../../text.txt");
            string[] actualResult = new string[wordsToFind.Length];
            SortedDictionary<string, int> exptectedResult = new SortedDictionary<string, int>();
            string[] exptectedRes = new string[wordsToFind.Length];
            for (int i = 0; i < wordsToFind.Length; i++)
            {
                string currentWord = wordsToFind[i];
                int countWords = countWordsInText(text, currentWord);
                actualResult[i] = $"{wordsToFind[i]} - {countWords}";


            }
            for (int i = 0; i < actualResult.Length; i++)
            {
                string[] act = actualResult[i].Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                exptectedResult.Add(act[0], int.Parse(act[1]));
            }
            File.WriteAllLines("../../../acturalResult.txt", actualResult);
            int counter = 0;
            foreach (var item in exptectedResult.OrderByDescending(x => x.Value))
            {
                exptectedRes[counter] = $"{item.Key} - {item.Value}";
                counter++;
            }
            File.WriteAllLines("../../../expectedResult.txt", exptectedRes);

        }

        static int countWordsInText(string[] text, string currentWord)
        {
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char[] delimiterChars = { ' ', ',', '.', ':', '!', '?', '-' };
                string[] currentText = text[i].Split(delimiterChars).ToArray();
                for (int r = 0; r < currentText.Length; r++)
                {
                    if (currentText[r].ToLower() == currentWord.ToLower())
                    {
                        counter++;
                    }
                }
                
            }
            return counter;
        }
    }
}
