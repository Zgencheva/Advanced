using System;

namespace ImplementingLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            for (int i = 0; i < 20; i++)
            {
                list.AddLast(i);
            }
            //list.PrintList();
            list.RemoveFirst();
            list.RemoveLast();
            list.RemoveLast();
            list.PrintList();

        }
    }
}
