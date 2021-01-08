using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComparingObjects
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            //Person a = new Person("Gosho", 15, "Burgas");
            //Person b = new Person("Pesho", 15, "Varna");

            //Console.WriteLine(a.CompareTo(b));

            List<Person> people = new List<Person>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }

                string[] tokens = command.Split().ToArray();
                people.Add(new Person(tokens[0], int.Parse(tokens[1]), tokens[2]));

            }

            int possition = int.Parse(Console.ReadLine());

            Person personToCompare = people[possition - 1];
            int countMatches = 0;
            for (int i = 0; i < people.Count; i++)
            {

                if (personToCompare.CompareTo(people[i]) == 0)
                {
                    countMatches++;
                }

            }

            if (countMatches == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{countMatches} {people.Count - countMatches} {people.Count}");
            }
        }
    }
}
