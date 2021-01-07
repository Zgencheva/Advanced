using System;
using System.Collections.Generic;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> topStudents = new List<Student>();
            for (int i = 0; i < 30; i++)
            {
                topStudents.Add(new Student());
            }
            //topStudents.Sort(new StudentsComparer()); //gets the comparator   
            int minIndex = 0;
            IComparer<Student> comparer = new StudentsComparer();
            for (int i = 0; i < topStudents.Count; i++)
            {
                for (int j = i; j < topStudents.Count; j++)
                {
                    if (comparer.Compare(topStudents[minIndex], topStudents[j]) > 0)
                    {
                        minIndex = j;   
                    }
                }

                Student temp = topStudents[minIndex];
                topStudents[minIndex] = topStudents[i];
                topStudents[i] = temp;
            }
            foreach (var student in topStudents)
            {
                Console.WriteLine($"{student.Name} - {student.Grade}");
            }
        } 
    }
}
