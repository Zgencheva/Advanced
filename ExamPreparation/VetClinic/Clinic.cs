using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        public List<Pet> Data { get; set; }
        public int Capacity { get; set; }

        public int Count { get => this.Data.Count; }

        public Clinic(int capacity)
        {
            this.Capacity = capacity;
            this.Data = new List<Pet>();
        }

        public void Add(Pet pet)
        {
            if (this.Capacity > this.Data.Count)
            {
                Data.Add(pet);
            }

        }

        public bool Remove(string name)
        {
            Pet petToRemove = Data.Where(x => x.Name == name).FirstOrDefault();
            return this.Data.Remove(petToRemove);
        }

        public Pet GetPet(string name, string owner)
        {
            Pet currentPet = Data.Where(x => x.Name == name).Where(y => y.Owner == owner).FirstOrDefault();
            return currentPet;
        }

        public Pet GetOldestPet()
        {
            return Data.OrderByDescending(x => x.Age).First();
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The clinic has the following patients:");
            foreach (Pet pet in this.Data)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
