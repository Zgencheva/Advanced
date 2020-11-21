using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> grades = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                string[] grade = Console.ReadLine().Split().ToArray();
                string name = grade[0];
                decimal currentGrade = decimal.Parse(grade[1]);
                if (!grades.ContainsKey(name))
                {
                    grades.Add(name, new List<decimal>());
                    grades[name].Add(currentGrade);
                }
                else
                {
                    grades[name].Add(currentGrade);
                }

            }

            foreach (var item in grades)
            {
                Console.Write($"{item.Key} -> ");
                foreach (decimal item2 in item.Value)
                {
                    Console.Write($"{item2:f2} ");
                }
                Console.WriteLine($"(avg: {item.Value.Average():f2})");
            }
        }
    }
}
