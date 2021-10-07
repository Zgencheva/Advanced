using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiRental
{
    public class SkiRental
    {
        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count => skiCollection.Count();

        public List<Ski> skiCollection { get; private set; }

        public SkiRental(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.skiCollection = new List<Ski>();
        }
        public void Add(Ski ski)
        {
            if (this.Capacity > this.Count)
            {
                skiCollection.Add(ski);
            }
            
        }

        public bool Remove(string manufacturer, string model)
        {
            Ski currentSki = skiCollection.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
            return skiCollection.Remove(currentSki);
        }

        public Ski GetNewestSki()
        {
            if (skiCollection.Count != 0)
            {
                return skiCollection.OrderByDescending(x => x.Year).FirstOrDefault();
            }
            return null;
        }

        public Ski GetSki(string manufacturer, string model)
        {
            return skiCollection.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
        }

        
        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"The skis stored in {this.Name}:");
            foreach (Ski item in skiCollection)
            {
                sb.AppendLine(item.ToString());
            }


            return sb.ToString();
        }
    }
}
