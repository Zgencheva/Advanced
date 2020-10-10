using System;
using System.Collections.Generic;

namespace SuperMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> clients = new Queue<string>();
            while (true)
            {
                string newClient = Console.ReadLine();
                if (newClient == "End")
                {
                    break;
                }
                if (newClient != "Paid")
                {
                    clients.Enqueue(newClient);
                }
                else
                {
                    while (clients.Count > 0)
                    {
                        Console.WriteLine(clients.Dequeue());
                    }
                }
            }
            Console.WriteLine($"{clients.Count} people remaining.");
        }
    }
}
