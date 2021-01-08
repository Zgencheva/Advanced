using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {

        private readonly int[] stones;

        
        public Lake(params int[] input)
        {
            this.stones = input;
        }

        public IEnumerator<int> GetEnumerator()
        {
            //custom iteration logic
            for (int i = 0; i < this.stones.Length; i+=2)
            {
                //returning element on even positions
                yield return this.stones[i];
            }

            for (int i = this.stones.Length - 1; i > 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return this.stones[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
