using GenericBoxofString;
using System;

namespace GenericBoxofInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                Box<int> thisBox = new Box<int>(current);
                Console.WriteLine(thisBox.ToString());



            }
        }
    }
}
