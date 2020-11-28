using System;
using System.IO;

namespace FileApi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            File.WriteAllText("../../../filedemo.txt", "easy coping");
            Console.WriteLine(File.Exists("../../../filedemo.txt"));
        }
    }
}
