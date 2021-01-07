using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace EnumeratorDemo
{
    public class StringEnumerator : IEnumerator<string>
    {
        private int index = -1;
        public string[] Array { get; set; }
        public StringEnumerator(string[] array)
        {
            this.Array = array;
        }

       
        public string Current => this.Array[index];

        object IEnumerator.Current => this.Array[index];

        public void Dispose()
        {
           
        }

        public bool MoveNext()
        {
            index++;
            if (Array.Length <= index)
            {
                return false;
            }

            return true;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
