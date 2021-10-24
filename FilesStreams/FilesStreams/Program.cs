using System;
using System.IO;
using System.Linq;

namespace FilesStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            //EvennLines();
            //LineNumbers();


        }

        private static void LineNumbers()
        {
            string[] lines = File.ReadAllLines("text.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                int countLetters = lines[i].Count(s => char.IsLetter(s));
                int countPunct = lines[i].Count(s => char.IsPunctuation(s));
                //Console.WriteLine($"Line {i + 1}: {lines[i]} ({countLetters})({countPunct})");
                File.AppendAllText("../../../output.txt", $"Line {i + 1}: {lines[i]} ({countLetters})({countPunct}){Environment.NewLine}");
            }
        }

        private static void EvennLines()
        {
            StreamReader streamReader = new StreamReader("text.txt");
            //string result = streamReader.ReadLine();
            int i = 0;
            string[] chars = new string[] { "-", ",", ".", "!", "?" };
            while (true)
            {
                string result = streamReader.ReadLine();
                if (result == null)
                {
                    break;
                }
                foreach (string item in chars)
                {
                    result = result.Replace(item, "@");
                }



                if (i % 2 == 0)
                {
                    Console.WriteLine(string.Join(" ", result.Split().Reverse()));
                }

                i++;
            }
        }
    }
}
