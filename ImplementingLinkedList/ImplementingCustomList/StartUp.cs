using System;

namespace ImplementingCustomList
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            CustomList newList = new CustomList();
            for (int i = 0; i <= 5; i++)
            {
                newList.Add(i);
            }

            Console.WriteLine(newList.ToString());
        }
    }
}
