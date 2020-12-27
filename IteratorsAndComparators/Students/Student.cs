using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Students
{
    public class Student : IComparable<Student>
    {

        Random rand = new Random();
        public Student()
        {
            this.Name = "Pesho" + rand.Next(0, 10000);
            this.Grade = rand.Next(2, 7);
        }
        public string Name { get; set; }
        public double Grade { get; set; }

        public int CompareTo(Student other)
        {
            return this.Grade.CompareTo(other.Grade);
        }
    }
}
