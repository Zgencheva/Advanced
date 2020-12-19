using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace GameSnake
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public Node Tail { get; set; }

        public void AddHead(Node newNode) //add head
        {
            if (Head == null)
            {
                this.Head = newNode;
                this.Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                this.Head.Previous = newNode;
                this.Head = newNode;
            }
            

        }

        //public void AddFirst(int element) 
        //{
        //    Node currentNode = new Node(element);
        //    if (Head == null)
        //    {
        //        this.Head = currentNode;
        //        this.Tail = currentNode;
        //    }
        //    else
        //    {
        //        currentNode.Next = Head;
        //        this.Head.Previous = currentNode;
        //        this.Head = currentNode;
        //    }


        //}

        public void AddLast(Node element)
        {
            Node currentnode = element;
            if (this.Tail == null)
            {
                this.Head = currentnode;
                this.Tail = currentnode;
            }
            else
            {
                currentnode.Previous = Tail;
                this.Tail.Next = currentnode;
                this.Tail = currentnode;
            }


        }

        public Node RemoveFirst()
        {
            var oldNode = this.Head;
            this.Head = this.Head.Next;
            Head.Previous = null;
            return oldNode;
        
        }

        public Node RemoveLast()
        {
            var oldNode = this.Tail;
            this.Tail = this.Tail.Previous;
            Tail.Next = null;
            return oldNode;

        }
        public void PrintList()
        {
            this.ForEach(node => Console.WriteLine(node.Value));

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
        public Node Peak()
        {
            return this.Head;
        }
        public void ForEach(Action<Node> action)
        {
            Node currentNode = Head;
            while (currentNode != null)
            {
                action(currentNode);
                currentNode = currentNode.Next;
            }
        
        }

        public void ReverseForEach(Action<Node> action)
        {
            Node currentNode = Tail;
            while (currentNode != null)
            {
                action(currentNode);
                currentNode = currentNode.Previous;
            }

        }

        public Node[] ToArray()
        {
            List<Node> list = new List<Node>();
            this.ForEach(node => list.Add(node));
            return list.ToArray();
        }

        public bool Remove(Node value)
        {
            Node currentNode = this.Head;
            while (currentNode != null)
            {
                if (currentNode == value)
                {
                    currentNode.Previous.Next = currentNode.Next;
                    currentNode.Next.Previous = currentNode.Previous;
                    return true;
                }
                currentNode = currentNode.Next;
               
            }
            return false;

        }

        public bool Find(Node value)
        {
            bool isFound = false;
            ForEach(x =>
           {
               if (x == value)
               {
                   isFound = true;
               }
           }
            );
            return isFound;
        }

        public void Reverse()
        {
            var oldHead = this.Head;
            this.Head = this.Tail;
            this.Tail = oldHead;
        
        }
    }
}
