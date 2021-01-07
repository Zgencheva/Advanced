using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class CustomStack<T>: IEnumerable<T>
    {
        public Stack<T> Data { get; set; }

        public CustomStack(Stack<T> data)
        {
            this.Data = data;
        }

        public T Pop()
        {
            return this.Data.Pop();
        
        }


        public IEnumerator<T> GetEnumerator()
        {
           yield return this.Data.Pop();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //private class ListyIteratorEnumerator : IEnumerator<T>
        //{
        //    public T Current => throw new NotImplementedException();

        //    object IEnumerator.Current => throw new NotImplementedException();

        //    public void Dispose()
        //    {
                
        //    }

        //    public bool MoveNext()
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void Reset()
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
    }
}
