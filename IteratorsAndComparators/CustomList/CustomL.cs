using System;
using System.Collections.Generic;
using System.Text;

namespace CustomList
{
    public class CustomL<T>
    {
        private T[] array;
        private int index = 0;

            public CustomL()
        {
            array = new T[8];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < index; i++)
            {
                yield return array[i];
            }
        }

        public void Add(T element)
        {
            array[index] = element;
            index++;
        }
    }
}
