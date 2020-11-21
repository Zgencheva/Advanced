using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();
            while (true)
            {
                string[] tokens = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (tokens[0] == "Revision")
                {
                    break;
                }
                string shopName = tokens[0];
                string product = tokens[1];
                double price = double.Parse(tokens[2]);
                if (!shops.ContainsKey(shopName))
                {
                    shops.Add(shopName, new Dictionary<string, double>());
                    
                }
                if (!shops[shopName].ContainsKey(product))
                {

                    shops[shopName].Add(product, price);
                }

            }

            foreach (var item in shops)
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"Product: {item2.Key}, Price: {item2.Value}");
                }
            }

        }
    }
}
