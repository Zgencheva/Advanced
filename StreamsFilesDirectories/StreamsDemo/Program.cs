using System;
using System.IO;

namespace StreamsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] buffer = new byte[100];
            //for (byte i = 0; i < 100; i++)
            //{
            //    buffer[i] = i;
            //}
            using (FileStream stream = new FileStream("../../../input.txt", FileMode.OpenOrCreate))
            {

                //stream.Write(buffer, 0, buffer.Length);

                Console.WriteLine($"Stram possition {stream.Position}");
                stream.Read(buffer, 0, 3);
                Console.WriteLine($"Stram possition {stream.Position}");
                stream.Read(buffer, 3, 3);
                Console.WriteLine($"Stram possition {stream.Position}");
                stream.Read(buffer, 6, 3);

                Console.WriteLine(string.Join(" ", buffer));
            }
        }
    }
}
