﻿using System;

namespace GenericBoxofString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string current = Console.ReadLine();
                Box<string> box = new Box<string>(current);
                Console.WriteLine(box.ToString());



            }
        }
    }
}
