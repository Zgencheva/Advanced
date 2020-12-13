using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Family
    {

        public List<Person> FamilyMembers { get; set; }

        public Family()
        {
            this.FamilyMembers = new List<Person>();
        }
        public void AddMember(Person member)
        {

            
            this.FamilyMembers.Add(member);
        }

        public Person GetOldestMember()
        {
            Person oldestMember = new Person(int.MinValue);

            for (int i = 0; i < this.FamilyMembers.Count; i++)
            {
                if (FamilyMembers[i].Age > oldestMember.Age)
                {
                    oldestMember = FamilyMembers[i];
                }
            }

            return oldestMember;
        }
    }
}
