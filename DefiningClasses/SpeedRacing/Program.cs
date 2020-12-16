using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;

namespace SpeedRacing
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                Car currentCar = new Car(tokens[0], double.Parse(tokens[1]), double.Parse(tokens[2]));
                cars.Add(currentCar);
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] tokens = input.Split();
                string modelToRide = tokens[1];
                double kmToDrive = double.Parse(tokens[2]);
                for (int i = 0; i < cars.Count; i++)
                {
                    if (cars[i].Model == modelToRide)
                    {
                        cars[i].Drive(modelToRide, kmToDrive);
                    }
                }

            }

            foreach (Car item in cars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.Travelleddistance}");
            }
        }
    }
}
