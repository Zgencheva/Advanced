using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace ImplementingCustomList
{
    public class CustomList<T> where T: IComparable
    {
        public CustomList()
        {
            this.items = new T[INITIAL_CAPACITY];
        }
        private const int INITIAL_CAPACITY = 2;
        private T[] items;
        public int Count { get; private set; } //private means we cannot manipulate the count outside the class

        public T this[int index]
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
            T[] copy = new T[this.items.Length * 2];
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
            T[] copy = new T[this.items.Length /2];
            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }

        public void Add(T item)
        {
            if (this.Count == this.items.Length)
            {
                this.Resize();
            }
            this.items[this.Count] = item;
            this.Count++;
        }

        public T RemoveAt(int index)
        {
           
            if (!this.IsValidIndex(index))
            {
                throw new ArgumentOutOfRangeException();
            }
            T item = this.items[index];
            this.items[index] = default(T);
            this.ShiftToLeft(index);

            this.Count--;
            if (this.Count <= this.items.Length / 4)
            {
                this.Shrink();
            }

            return item;
        }

        public void Insert(int index, T item)
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

        public bool Contains(T element)
        {
            //bool isItInTheCOllection = false;
            for (int i = 0; i < this.Count; i++)
            {
                if (items[i].Equals(element))
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
            T elementAtFirstIndex = this.items[firstIndex];
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
