using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            while (true)
            {

                string command = Console.ReadLine();
                if (command == "No more tires")
                {
                    break;
                }

                string[] tokens = command.Split().ToArray();
                var currentTires = new Tire[4]
                {
                    new Tire(int.Parse(tokens[0]), double.Parse(tokens[1])),
                    new Tire(int.Parse(tokens[2]), double.Parse(tokens[3])),
                    new Tire(int.Parse(tokens[4]), double.Parse(tokens[5])),
                    new Tire(int.Parse(tokens[6]), double.Parse(tokens[7])),

                };
                tires.Add(currentTires);
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Engines done")
                {
                    break;
                }

                string[] tokens = command.Split().ToArray();
                Engine currentEngine = new Engine(int.Parse(tokens[0]), double.Parse(tokens[1]));
                engines.Add(currentEngine);
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Show special")
                {
                    break;
                }

                string[] tokens = command.Split().ToArray();
                Car currentCar = new Car(tokens[0],
                        tokens[1],
                        int.Parse(tokens[2]),
                        double.Parse(tokens[3]),
                        double.Parse(tokens[4]),
                        engines[int.Parse(tokens[5])],
                        tires[int.Parse(tokens[6])]);
                cars.Add(currentCar);
            }
            List<Car> specialCars = cars.Where(x => x.Year >= 2017).ToList();
            specialCars = specialCars.Where(y => y.Engine.HorsePower >= 330).ToList();
            specialCars = specialCars.Where(t => t.Tires.Sum(y => y.Pressure) >= 9 && t.Tires.Sum(y => y.Pressure) <= 10).ToList();



            for (int i = 0; i < specialCars.Count; i++)
            {
                specialCars[i].Drive(20);
                Console.WriteLine(specialCars[i].WhoAmI());
            }

            
        }
    }
}
