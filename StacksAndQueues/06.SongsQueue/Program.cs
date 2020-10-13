using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Queue<string> playlist = new Queue<string>(songs);

            while (playlist.Count > 0)
            {
                string command = Console.ReadLine();

                if (command.Contains("Add"))
                {
                    string currentSong = command.Substring(4, command.Length - 4);
                    if (playlist.Contains(currentSong))
                    {
                        Console.WriteLine($"{currentSong} is already contained!");

                    }
                    else
                    {
                        playlist.Enqueue(currentSong);

                    }
                }
                else if (command == "Play")
                {
                    playlist.Dequeue();

                }
                else if (command == "Show")
                {

                    Console.WriteLine(string.Join(", ", playlist));
                }

                
            }
            Console.WriteLine("No more songs!");
        }
    }
}
