using GenericBoxofString;
using System;
using System.Linq;

namespace Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] firstBox = Console.ReadLine().Split().ToArray();
            string item1 = $"{firstBox[0]} {firstBox[1]}";
            string item2 = firstBox[2];
            Tuple<string, string> box1 = new Tuple<string, string>(item1, item2);
            Console.WriteLine(box1.ToString());

            string[] secondBox = Console.ReadLine().Split().ToArray();
            string it1 = secondBox[0];
            int it2 = int.Parse(secondBox[1]);
            Tuple<string, int> box2 = new Tuple<string, int>(it1, it2);
            Console.WriteLine(box2.ToString());

            string[] thirdBox = Console.ReadLine().Split().ToArray();
            int it31 = int.Parse(thirdBox[0]);
            double it32 = double.Parse(thirdBox[1]);
            Tuple<int, double> box3 = new Tuple<int, double>(it31, it32);
            Console.WriteLine(box3.ToString());
        }
    }
}
