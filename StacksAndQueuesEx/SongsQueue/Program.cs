using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ").ToArray();
            Queue<string> playlist = new Queue<string>(songs);

            while (playlist.Count > 0)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                string command = cmd[0];
                if (command == "Play")
                {
                    playlist.Dequeue();
                    
                }
                else if (command == "Add")
                {
                   
                    StringBuilder sb = new StringBuilder();
                    for (int i = 1; i < cmd.Length; i++)
                    {
                        sb.Append($"{cmd[i]} ");
                    }
                    string song = sb.ToString().TrimEnd();
                    if (!playlist.Contains(song))
                    {
                        playlist.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
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
