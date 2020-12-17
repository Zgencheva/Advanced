using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = 0;
            this.Color = "n/a";
        }

        public Car(string model, Engine engine, int weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Model+':');
            sb.AppendLine($"  {this.Engine.Model}:");
            sb.AppendLine($"    Power: {this.Engine.Power}");
            
            if (this.Engine.Displacement == 0)
            {
                sb.AppendLine($"  Displacement: n/a");
            }
            else
            {
                sb.AppendLine($"    Displacement: {this.Engine.Displacement}");
            }
            sb.AppendLine($"    Efficiency: {this.Engine.Efficiency}");
            if (this.Weight == 0)
            {
                sb.AppendLine($"  Weight: n/a");
            }
            else
            {
                sb.AppendLine($"  Weight: {this.Weight}");
            }
            
            sb.Append($"  Color: {this.Color}");
            return sb.ToString(); 
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }

        public int Weight { get; set; }
        public string Color { get; set; }

    }
}
