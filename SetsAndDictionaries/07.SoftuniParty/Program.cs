using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _07.SoftuniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guests = new HashSet<string>();
            while (true)
            {
                string guest = Console.ReadLine();
                if (guest == "PARTY")
                {
                    break;
                }
                guests.Add(guest);
            }
            while (true)
            {
                string guest = Console.ReadLine();
                if (guest == "END")
                {
                    break;
                }
                guests.Remove(guest);
            }

            Console.WriteLine(guests.Count);
            foreach (var item in guests)
            {
                if (item.StartsWith('1') || item.StartsWith('2') || item.StartsWith('3') || item.StartsWith('4')
                    || item.StartsWith('5') || item.StartsWith('6') || item.StartsWith('7') || item.StartsWith('8')
                    || item.StartsWith('9') || item.StartsWith('0'))
                {
                    Console.WriteLine(item);
                    
                }
               
            }
            foreach (var item in guests)
            {
                if (!(item.StartsWith('1') || item.StartsWith('2') || item.StartsWith('3') || item.StartsWith('4')
                    || item.StartsWith('5') || item.StartsWith('6') || item.StartsWith('7') || item.StartsWith('8')
                    || item.StartsWith('9') || item.StartsWith('0')))
                {
                    Console.WriteLine(item);

                }

            }
        }
    }
}
