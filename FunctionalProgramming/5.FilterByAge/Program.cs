using System;
using System.Linq;

namespace _5.FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Person[] people = new Person[n];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                people[i] = new Person(input[0], int.Parse(input[1]));

            }
            string olderOrYounger = Console.ReadLine();
            int ageCondition = int.Parse(Console.ReadLine());
            string printing = Console.ReadLine();
            Func<Person, bool> conditionDelegate = GetCondition(ageCondition, olderOrYounger);
            Action<Person> printDelegate = GetPrinter(printing);
            FilterPeople(people, conditionDelegate, printDelegate);
            

        }
        static void FilterPeople(Person[] people, Func<Person, bool> filter, Action<Person> print)
        {
            foreach (var person in people)
            {
                if (filter(person))
                {
                    print(person);
                }
            }

        }

        static Action<Person> GetPrinter(string printing)
        {
            switch (printing)
            {
                case "name age":
                    return p => 
                    {
                        Console.WriteLine($"{p.Name} - {p.Age}"); 
                    };
                case "name":
                    return p =>
                    {
                        Console.WriteLine($"{p.Name}");
                    };
                case "age":
                    return p =>
                    {
                        Console.WriteLine($"{p.Age}");
                    };
                default:
                    return null;
                  
            }

        }
        static Func<Person, bool> GetCondition (int ageCondition, string youngerOrOlder)
            {
            switch (youngerOrOlder)
            {
                case "younger":
                    return p => p.Age < ageCondition;
                case "older":
                    return p => p.Age >= ageCondition;
                default:
                    return null;
                  
                    
            }
        }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
}
