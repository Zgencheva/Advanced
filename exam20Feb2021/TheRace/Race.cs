using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        public List<Racer> data { get; private set; }
        public Race(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new List<Racer>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count => this.data.Count();

        public void Add(Racer racer)
        {
            if (this.Capacity > data.Count())
            {
                data.Add(racer);

            }


        }

        public bool Remove(string name)
        {
            Racer current = data.FirstOrDefault(x => x.Name == name);
            return data.Remove(current);
        }

        public Racer GetOldestRacer()
        {
            return data.OrderByDescending(x => x.Age).FirstOrDefault();
        }

        public Racer GetRacer(string name)
        {
            if (data.Count() != 0)
            {
                return data.FirstOrDefault(x => x.Name == name);

            }
            return null;
            
        }

        public Racer GetFastestRacer()
        {
            if (data.Count != 0)
            {
                return data.OrderByDescending(x => x.Car.Speed).FirstOrDefault();
            }
            return null;
            
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Racers participating at {this.Name}:");
            foreach (Racer racer in data)
            {
                sb.AppendLine(racer.ToString());
            }
            return sb.ToString();
        }

    }
}
