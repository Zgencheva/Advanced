using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace ImplementingCustomList
{
    public class CustomList
    {
        public CustomList()
        {
            this.items = new int[INITIAL_CAPACITY];
        }
        private const int INITIAL_CAPACITY = 2;
        private int[] items;
        public int Count { get; private set; } //private means we cannot manipulate the count outside the class

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
            int[] copy = new int[this.items.Length * 2];
            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }

        private void ShiftToLeft(int index)
        {
            if (!IsValidIndex(index))
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = index; i < this.Count - 1; i++)
            {
                this.items[i] = this.items[i + 1];
            }
            for (int i = this.Count - 1; i < this.items.Length; i++)
            {
                this.items[i] = default;
            }
        }

        private void ShiftToRight(int index)
        {
            if (!IsValidIndex(index))
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = this.Count; i > index; i--)
            {
                this.items[i] = this.items[i -1];
            }
            //for (int i = this.Count - 1; i < this.items.Length; i++)
            //{
            //    this.items[i] = default;
            //}
        }

        private void Shrink()
        {
            int[] copy = new int[this.items.Length /2];
            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }

        public void Add(int item)
        {
            if (this.Count == this.items.Length)
            {
                this.Resize();
            }
            this.items[this.Count] = item;
            this.Count++;
        }

        public int RemoveAt(int index)
        {
           
            if (!this.IsValidIndex(index))
            {
                throw new ArgumentOutOfRangeException();
            }
            var item = this.items[index];
            this.items[index] = default(int);
            this.ShiftToLeft(index);

            this.Count--;
            if (this.Count <= this.items.Length / 4)
            {
                this.Shrink();
            }

            return item;
        }

        public void Insert(int index, int item)
        {
            if (!IsValidIndex(index))
            {
                throw new ArgumentOutOfRangeException();
            }
            
            if (this.Count == this.items.Length)
            {
                this.Resize();
            }
            
            this.ShiftToRight(index);
            this.items[index] = item;
            this.Count++;
        }

        public bool Contains(int element)
        {
            //bool isItInTheCOllection = false;
            for (int i = 0; i < this.Count; i++)
            {
                if (items[i] == element)
                {
                    //isItInTheCOllection = true;
                    //break;
                    return true;
                }
            }
            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            if (!IsValidIndex(firstIndex) || !IsValidIndex(secondIndex))
            {
                throw new ArgumentOutOfRangeException();
            }
            //additional variable
            int elementAtFirstIndex = this.items[firstIndex];
            this.items[firstIndex] = this.items[secondIndex];
            this.items[secondIndex] = elementAtFirstIndex;

            
        }
        private bool IsValidIndex(int index)
            => index < this.Count;
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                if (i == this.Count - 1)
                {
                    //final operation
                    sb.Append(this.items[i]);
                }
                else
                {
                    sb.Append($"{this.items[i]}, ");
                }
                
            }
            return sb.ToString().TrimEnd();
        }
    }
}
