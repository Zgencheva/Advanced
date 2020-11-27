using System;
using System.IO;

namespace _2.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("../../../Program.cs"))
            {
                using (var writer = new StreamWriter("../../../output.txt"))
                {
                    var line = reader.ReadLine();
                    int index = 1;
                    while (line != null)
                    {
                        writer.WriteLine($"{index}. {line}");
                        Console.WriteLine($"{index}. {line}");
                        index++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
