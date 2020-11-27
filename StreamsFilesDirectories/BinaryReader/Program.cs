using System;
using System.IO;

namespace BinaryReader
{
    class Program
    {
        static void Main(string[] args)
        {
            //first way
            using (StreamReader reader = new StreamReader("../../../input.txt"))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
            ////second way
            //StreamReader reader2 = new StreamReader("../../../input.txt");
            //try
            //{
            //    Console.WriteLine(reader2.ReadToEnd());
            //}
            //finally
            //{

            //    reader2.Close();
            //}
        }
    }
}
