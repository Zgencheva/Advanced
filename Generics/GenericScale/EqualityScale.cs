using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace GenericScale
{
    class EqualityScale<T>
    {

        public T Left { get; set; }
        public T Right { get; set; }

        public EqualityScale(T left, T right)
        {
            this.Left = left;
            this.Right = right;
        }

        public bool AreEqual()
        {
            bool areEguql = false;
            if (this.Left.Equals(this.Right))
            {
                areEguql = true;
            }

            return areEguql;
        }


    }
}
