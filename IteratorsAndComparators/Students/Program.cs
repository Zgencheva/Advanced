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
            topStudents.Sort(new StudentsComparer()); //gets the comparator   
            foreach (var student in topStudents)
            {
                Console.WriteLine($"{student.Name} - {student.Grade}");
            }
        } 
    }
}
