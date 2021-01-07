using System;
using System.Collections.Generic;

namespace fsdfsdfsd
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = new List<int>();
            for (int i = 0; i < 30; i++)
            {
                mylist.Add(i);
            }

            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }
        }
    }
}
