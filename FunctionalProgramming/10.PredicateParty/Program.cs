using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace _10.PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> partyPeople = Console.ReadLine().Split().ToList();
            while (true)
            {
                string command = Console.ReadLine();
                
                if (command == "Party!")
                {
                    break;
                }

                string[] tokens = command.Split().ToArray();
                Predicate<string> predicateStartsWith = x => x.StartsWith(tokens[2]);
                Predicate<string> predicateEndsWith = x => x.EndsWith(tokens[2]);
                Predicate<string> predicateNameLength = x => x.Length == int.Parse(tokens[2]);

                
                if (tokens[0] == "Remove")
                {
                    if (tokens[1] == "StartsWith")
                    {
                        partyPeople.RemoveAll(predicateStartsWith);
                    }
                    else if (tokens[1] == "EndsWith")
                    {
                        partyPeople.RemoveAll(predicateEndsWith);
                    }
                    else if (tokens[1] == "Length")
                    {
                        partyPeople.RemoveAll(predicateNameLength);
                    }
                }
                if (tokens[0] == "Double")
                {
                    string nameToaAdd = null;
                    int times = 0;
                    if (tokens[1] == "StartsWith")
                    {
                        foreach (var item in partyPeople)
                        {
                            if (predicateStartsWith(item))
                            {
                                nameToaAdd = item;
                                times++;
                            }
                        }
                    }
                    else if (tokens[1] == "EndsWith")
                    {
                        foreach (var item in partyPeople)
                        {
                            if (predicateEndsWith(item))
                            {
                                nameToaAdd = item;
                                times++;
                            }
                        }
                    }
                    else if (tokens[1] == "Length")
                    {
                        
                        foreach (var item in partyPeople)
                        {
                            if (predicateNameLength(item))
                            {
                                nameToaAdd = item;
                                times++;
                            }
                        }
                       
                    }
                    for (int i = 0; i < times; i++)
                    {
                        partyPeople.Add(nameToaAdd);
                    }
                }

            }

            if (partyPeople.Count != 0)
            {
                Console.WriteLine($"{string.Join(", ", partyPeople)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            

        }

        
    }
}
