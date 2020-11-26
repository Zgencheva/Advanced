using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace _7.TheVLogger
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Vlogger> vloggers = new Dictionary<string, Vlogger>();
            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                if (command[0] == "Statistics")
                {
                    break;
                }
                if (command.Length == 4)
                {
                    string currentName = command[0];
                    if (vloggers.ContainsKey(currentName))
                    {
                        continue;
                    }
                    Vlogger currentInput = new Vlogger(currentName);
           
                   
                    vloggers.Add(currentName, currentInput);
                }
                else if (command.Length == 3)
                {
                    string follow1 = command[0];
                    string follo2 = command[2];
                    if (vloggers.ContainsKey(follo2) && vloggers.ContainsKey(follow1) && follow1 != follo2)
                    {
                        foreach (var item in vloggers)
                        {
                            if (item.Key == follow1)
                            {
                                if (!item.Value.Following.Contains(follo2))
                                {

                                item.Value.Following.Add(follo2);
                                }
                            }
                            else if (item.Key == follo2)
                            {
                                if (!item.Value.Followers.Contains(follow1))
                                {
                                item.Value.Followers.Add(follow1);

                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            
            int current = 1;
            foreach (var item in vloggers.OrderByDescending(x => x.Value.Followers.Count).ThenBy(y => y.Value.Following.Count))
            {
                if (current == 1)
                {
                    Console.WriteLine($"1. {item.Value.Name} : {item.Value.Followers.Count} followers, {item.Value.Following.Count} following");
                    foreach (var follower in item.Value.Followers.OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                else
                {

                Console.WriteLine($"{current}. {item.Value.Name} : {item.Value.Followers.Count} followers, {item.Value.Following.Count} following");
                }
                current++;
            }
        }

        public class Vlogger
        {
            public string Name { get; set; }
            public List<string> Followers { get; set; }
            public List<string> Following { get; set; }

            public Vlogger(string name)
            {
                this.Name = name;
                this.Followers = new List<string>();
                this.Following = new List<string>();
            }

           
        }
    }
}
