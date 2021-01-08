using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ComparingObjects
{
    public class Person: IComparable<Person>
    {
        public string Name { get; set; }

        public int Age { get; set; }
        public string Town { get; set; }

        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public int CompareTo(Person other)
        {
            //returns int - 0 if equal, -1 other si bigger, 1 THIS is bigger
            int result = 1; //THIS is bigger
            if (other != null)
            {
                //comparing
                result = this.Name.CompareTo(other.Name);
                if (result == 0)
                {
                    //I continue with other criteria
                    result = this.Age.CompareTo(other.Age);
                    if (result == 0)
                    {
                        //I continue with third criteria
                        result = this.Town.CompareTo(other.Town);
                    }
                }

            }

            return result;
        }
    }
}
