using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split().ToArray();
                Person newPerson = new Person(tokens[0], int.Parse(tokens[1]));
                people.Add(newPerson);

            }

            foreach (Person item in people.Where(x => x.Age > 30).OrderBy(y => y.Name))
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
        }
    }
}
