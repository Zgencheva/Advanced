using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementCustomStack
{
    public class CustomStack
    {
        public CustomStack()
        {
            this.count = 0;
            this.items = new int[INITIAL_CAPACITY];
        }
        
        private int count { get; set; }

        private const int INITIAL_CAPACITY = 2;
        private int[] items;

        public int this[int index]
        {
            get
            {
                if (!this.IsValidIndex(index))
                {
                    throw new ArgumentOutOfRangeException();
                }
                return items[index];
            }

            set
            {
                if (!this.IsValidIndex(index))
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.items[index] = value;
            }
        } //index of the CLASS

        private void Resize()
        {
            int[] newList = new int[this.items.Length * 2];
            for (int i = 0; i < this.count; i++)
            {
                newList[i] = this.items[i];

            }
            this.items = newList;
        }

        public int Count
        {
            get
            {
                return this.Count;
            }

        }

        public void Push(int element)
        {
            if (this.items.Length == this.count)
            {
                this.Resize();
            }
            this.items[this.count] = element;
            count++;
        }

        public int Pop()
        {
            if (this.items.Length == 0)
            {
                throw new InvalidOperationException("CustomStack is empty");
            }

            var lastIndex = this.count - 1;
            int last = this.items[lastIndex];
            this.items[lastIndex] = default(int);
            count--;
            return last;
        }

        public int Peek()
        {
            if (this.items.Length == 0)
            {
                throw new InvalidOperationException("CustomStack is empty");
            }

            var lastIndex = this.count - 1;
            int last = this.items[lastIndex];
            return last;
        }

        public void ForEach(Action<object> action)
        {
            for (int i = 0; i < this.count; i++)
            {
                action(this.items[i]);
            }
        }

        private bool IsValidIndex(int index)
            => index < this.Count;

        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    for (int i = 0; i < this.Count; i++)
        //    {
        //        if (i == this.Count - 1)
        //        {
        //            //final operation
        //            sb.Append(this.items[i]);
        //        }
        //        else
        //        {
        //            sb.Append($"{this.items[i]}, ");
        //        }

        //    }
        //    return sb.ToString().TrimEnd();
        //}

    }
}
