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
            string item3 = firstBox[3];
            ThreeUple<string, string, string> box1 = new ThreeUple<string, string, string>(item1, item2, item3);
            Console.WriteLine(box1.ToString());

            string[] secondBox = Console.ReadLine().Split().ToArray();
            string it1 = secondBox[0];
            int it2 = int.Parse(secondBox[1]);
            string it3 = secondBox[2];
            bool isDrunk = false;
            if (it3 == "drunk")
            {
                isDrunk = true;
            }
            else if (it3 == "not")
            {
                isDrunk = false;
            }
            ThreeUple<string, int, bool> box2 = new ThreeUple<string, int, bool>(it1, it2, isDrunk);
            Console.WriteLine(box2.ToString());

            string[] thirdBox = Console.ReadLine().Split().ToArray();
            string it31 = thirdBox[0];
            double it32 = double.Parse(thirdBox[1]);
            string it33 = thirdBox[2];
            ThreeUple<string, double, string> box3 = new ThreeUple<string, double, string>(it31, it32, it33);
            Console.WriteLine(box3.ToString());
        }
    }
}
