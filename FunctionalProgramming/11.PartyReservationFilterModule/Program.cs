using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> partyPeople = Console.ReadLine().Split().ToList();
            List<string> filters = new List<string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Print")
                {
                    break;
                }
                string[] tokens = command.Split(";").ToArray();
                if (tokens[0] == "Add filter")
                {
                    filters.Add($"{tokens[1]};{tokens[2]}");
                }
                else if (tokens[0] == "Remove filter")
                {
                    filters.Remove($"{tokens[1]};{tokens[2]}");
                }
            }

            for (int i = 0; i < filters.Count; i++)
            {
                
                string[] command = filters[i].Split(";").ToArray();
                Func<string, bool> predicateStartsWith = x => !x.StartsWith(command[1]);
                Func<string, bool> predicateEndsWith = x => !x.EndsWith(command[1]);
                Func<string, bool> predicateNameLength = x => !(x.Length == int.Parse(command[1]));
                Func<string, bool> predicateContains = x => !x.Contains(command[1]);
                if (command[0] == "Starts with")
                {
                    partyPeople = partyPeople.Where(predicateStartsWith).ToList();
                }
                else if (command[0] == "Ends with")
                {
                    partyPeople = partyPeople.Where(predicateEndsWith).ToList();
                }
                else if (command[0] == "Length")
                {
                    partyPeople = partyPeople.Where(predicateNameLength).ToList();
                }
                else if (command[0] == "Contains")
                {
                    partyPeople = partyPeople.Where(predicateContains).ToList();
                }
                
            }

            Console.WriteLine(string.Join(" ", partyPeople));
        }
    }
}
