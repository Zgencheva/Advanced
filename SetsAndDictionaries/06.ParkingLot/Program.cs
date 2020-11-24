using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parkingLot = new HashSet<string>();
            while (true)
            {
                string[] command = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (command[0] == "END")
                {
                    break;
                }
                string direction = command[0];
                string carNum = command[1];
                if (direction == "IN")
                {
                    parkingLot.Add(carNum);
                }
                else if (direction == "OUT")
                {
                    parkingLot.Remove(carNum);
                }
            }

            if (parkingLot.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var item in parkingLot)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
