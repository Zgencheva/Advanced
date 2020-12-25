using GenericBoxofString;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace GenericCountMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<double> currentList = new List<double>();
            for (int i = 0; i < n; i++)
            {
                currentList.Add(double.Parse(Console.ReadLine()));
            }
            double valueToCompare = double.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();
            box.List = currentList;
            int count = box.CountOfGreaterElements(valueToCompare);
            Console.WriteLine(count);


            
        }

        public static int GetGreaterValue<T>(List<T> sourse, T value) where T : IComparable
        {

            int count = 0;
            for (int i = 0; i < sourse.Count; i++)
            {
                if (sourse[i].CompareTo(value) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
