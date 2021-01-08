using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace IteratorsAndComparatorsTasks02
{
    public class StackIEnum<T> : IEnumerable<T>
    {
        public Stack<T> stack { get; set; }

        public T indexOfStack { get; set; }

        public StackIEnum(Stack<T> stackToUse)
        {
            this.stack = stackToUse;
        }


        public void Pop(Stack<T> customStackToUse)
        {
            try
            {
                this.stack.Pop();
            }
            catch (InvalidOperationException)
            {

                Console.WriteLine("No elements");
            }



        }

        public void Push(Stack<T> customStackToUse, T element)
        {
            this.indexOfStack = element;

            this.stack.Push(this.indexOfStack);
        }





        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.stack)
            {
                yield return item;
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
