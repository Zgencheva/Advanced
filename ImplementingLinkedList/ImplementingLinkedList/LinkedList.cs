using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementingLinkedList
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public Node Tail { get; set; }

        public void AddHead(Node node)
        {
            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.Next = Head;
                Head.Previous = node;
                Head = node;
            }
            

        }

        public void PrintList()
        {
            Node currentNode = Head;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }

        }

        public void ReversedPrintList()
        {
            Node currentNode = Tail;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Previous;
            }

        }

        public Node Pop()
        {
            Node oldHead = Head;
            this.Head = Head.Next;
            return oldHead;
        }
    }
}
