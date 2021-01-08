using System;
using System.Collections.Generic;
using System.Linq;

namespace EqualityLogic
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Person a = new Person("Pesho", 18);
            //Person b = new Person("Pesho", 18);
            //Console.WriteLine(a.Equals(b)); //returns true
            //Console.WriteLine(a==b); //returns false and both are going in the HashSet



            int n = int.Parse(Console.ReadLine());
            SortedSet<Person> peopleSortedSet = new SortedSet<Person>();
            HashSet<Person> peopleHashSet = new HashSet<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split().ToArray();
                Person newPerson = new Person(tokens[0], int.Parse(tokens[1]));
                peopleHashSet.Add(newPerson);
                peopleSortedSet.Add(newPerson);

            }

            Console.WriteLine(peopleSortedSet.Count);
            Console.WriteLine(peopleHashSet.Count);
        }
    }
}
