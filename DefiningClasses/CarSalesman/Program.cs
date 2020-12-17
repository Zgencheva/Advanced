using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace CarSalesman
{
    public class Program
    {
        static void Main(string[] args)
        {
            int enginesN = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            for (int i = 0; i < enginesN; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 4)
                {
                    Engine currentEngine = new Engine(tokens[0], int.Parse(tokens[1]), int.Parse(tokens[2]), tokens[3]);
                    engines.Add(currentEngine);
                }
                else if (tokens.Length == 3)
                {
                    
                    if (char.IsDigit(tokens[2][0]))
                    {
                        Engine currentEngine = new Engine(tokens[0], int.Parse(tokens[1]), int.Parse(tokens[2]), "n/a");
                        engines.Add(currentEngine);
                    }
                    else
                    {
                        Engine currentEngine = new Engine(tokens[0], int.Parse(tokens[1]), 0, tokens[2]);
                        engines.Add(currentEngine);
                    }
                }
                else
                {
                    Engine currentEngine = new Engine(tokens[0], int.Parse(tokens[1]));
                    engines.Add(currentEngine);
                }
                

            }
            int carsN = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < carsN; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 4)
                {
                    Car currentCar = new Car(tokens[0], engines.Where(x => x.Model == tokens[1]).FirstOrDefault(), int.Parse(tokens[2]), tokens[3]);
                    cars.Add(currentCar);
                }
                else if (tokens.Length == 3)
                {

                    if (char.IsDigit(tokens[2][0]))
                    {
                        Car currentCar = new Car(tokens[0], engines.Where(x => x.Model == tokens[1]).FirstOrDefault(), int.Parse(tokens[2]), "n/a");
                        cars.Add(currentCar);
                    }
                    else
                    {
                        Car currentCar = new Car(tokens[0], engines.Where(x => x.Model == tokens[1]).FirstOrDefault(),0, tokens[2]);
                        cars.Add(currentCar);
                    }
                }
                else
                {
                    Car currentCar = new Car(tokens[0], engines.Where(x => x.Model == tokens[1]).FirstOrDefault());
                    cars.Add(currentCar);
                }

            }

            foreach (Car item in cars)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
