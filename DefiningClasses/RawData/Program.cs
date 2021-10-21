using System;
using System.Collections.Generic;

namespace RawData
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string model = tokens[0];
                int engineSpeed = int.Parse(tokens[1]);
                int enginePower = int.Parse(tokens[2]);
                Engine currentEngine = new Engine(engineSpeed, enginePower);
                int cargoWeight = int.Parse(tokens[3]);
                string cargoType = tokens[4];
                Cargo currentCargo = new Cargo(cargoWeight, cargoType);
                Tire[] tires = new Tire[4]
                {
                    new Tire(double.Parse(tokens[5]), int.Parse(tokens[6])),
                    new Tire(double.Parse(tokens[7]), int.Parse(tokens[8])),
                    new Tire(double.Parse(tokens[9]), int.Parse(tokens[10])),
                    new Tire(double.Parse(tokens[11]), int.Parse(tokens[12]))
                };

                Car currentCar = new Car(model, currentEngine, currentCargo, tires);
                cars.Add(currentCar);
            }

            string output = Console.ReadLine();
            if (output == "fragile")
            {
                foreach (Car item in cars)
                {
                    if (item.Cargo.Type == "fragile")
                    {
                        bool isPressureUnder1 = false;
                        for (int i = 0; i < 4; i++)
                        {
                            if (item.Tires[i].Pressure < 1)
                            {
                                isPressureUnder1 = true;
                                break;
                            }
                        }
                        if (isPressureUnder1)
                        {
                            Console.WriteLine(item.Model);
                        }
                    }
                }
            }
            else if (output == "flammable")
            {
                foreach (Car item in cars)
                {
                    if (item.Cargo.Type == "flammable" && item.Engine.Power > 250 )
                    {
                        Console.WriteLine(item.Model);
                    }
                }
            }
        }
    }
}
