using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace GenericArrayCreator
{
    public class ArrayCreator
    {

       public static T[] Create<T>(int length, T item)
        {
            T[] current = new T[length];
            for (int i = 0; i < current.Length; i++)
            {
                current[i] = item;
            }

            return current;
        }
    }
}
