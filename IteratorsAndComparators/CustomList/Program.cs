using System;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomL<int> list = new CustomL<int>();
            list.Add(5);
            list.Add(3);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
