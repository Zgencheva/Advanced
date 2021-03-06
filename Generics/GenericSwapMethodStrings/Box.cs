﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace GenericBoxofString
{
    public class Box<T>
    {
        public List<T> List { get; set; }

        public Box()
        {
            this.List = new List<T>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in this.List)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }

            return sb.ToString();
        }

        public List<T> Swap(int firstIndex, int seconIndex)
        {

            
            T current = this.List[firstIndex];
            this.List[firstIndex] = this.List[seconIndex];
            this.List[seconIndex] = current;
            return this.List;
        }
    }
}
