using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> MyStack;
        public int Count => this.MyStack.Count;

        public Box()
        {
            this.MyStack = new Stack<T>();
        }

        public void Add(T element)
        {
            MyStack.Push(element);
        }
        public T Remove()
        {
           return  this.MyStack.Pop();
        }

    }
}
