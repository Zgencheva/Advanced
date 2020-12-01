using System;
using System.IO;
using System.Linq;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("../../../text.txt");
            string[] result = new string[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string currentLine = lines[i];
                int countLetters = CountAllLetters(currentLine);
                int countMarks = CountAllPunctuationMarks(currentLine);
                result[i] = $"Line {i + 1}: {lines[i]} ({countLetters})({countMarks})";

            }

            File.WriteAllLines("../../../output.txt", result);

        }

        static int CountAllLetters(string line)
        {
            int count = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (char.IsLetter(line[i]))
                {
                    count++;
                }
            }

            return count;    
        }

        static int CountAllPunctuationMarks(string line)
        {
            int count = 0;
            char[] punctuationMarks = new char[] { '-', ',', '.', '!', '?', ';' };
            for (int i = 0; i < line.Length; i++)
            {
                if (punctuationMarks.Contains(line[i]))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
