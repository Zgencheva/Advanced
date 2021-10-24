using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StreetRacing
{
    public class Race
    {
        public Race(string name, string type, int laps, int capacity, int maxHorsePower)
        {
            this.Name = name;
            this.Type = type;
            this.Laps = laps;
            this.Capacity = capacity;
            this.MaxHorsePower = maxHorsePower;
            this.Participants = new List<Car>();
        }

        public List<Car> Participants  { get; private set; }
        public int Count => this.Participants.Count;
        public string Name { get; set; }
        public string Type { get; set; }
        public int Laps { get; set; }

        

        public int Capacity { get; set; }
        public int MaxHorsePower { get; set; }

        //        •	Name: string
        //•	Type: string
        //•	Laps: int
        //•	Capacity: int - the maximum allowed number of participants in the race
        //•	MaxHorsePower: int - the maximum allowed Horse Power of a Car in the Race
        public void Add(Car car)
        {
            if (Participants.Any(x=> x.LicensePlate == car.LicensePlate))
            {
                return;
            }
            if (car.HorsePower > this.MaxHorsePower)
            {
                return;
            }
            if (Capacity > this.Participants.Count)
            {
                Participants.Add(car);
            }
        }

        public bool Remove(string licensePlate)
        {
            Car current = Participants.Where(x=> x.LicensePlate == licensePlate).FirstOrDefault();
            return Participants.Remove(current);
        }

        public Car FindParticipant(string licensePlate)
        {
            if (this.Participants.Count > 0)
            {
                if (Participants.Any(x=> x.LicensePlate == licensePlate))
                {
                    return Participants.FirstOrDefault(x => x.LicensePlate == licensePlate);
                }
                else
                {
                    return null;
                }
                
            }
            else
            {
                return null;
            }
            
        }

        public Car GetMostPowerfulCar()
        {
            if (this.Participants.Count > 0)
            {
                return Participants.OrderByDescending(x => x.HorsePower).FirstOrDefault();
            }
            return null;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Race: {Name} - Type: {Type} (Laps: {Laps})");
            sb.AppendLine(string.Join("\n", Participants));
            return sb.ToString().Trim();
        }
    }
}