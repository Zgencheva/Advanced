﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Engine
    {
        public int HorsePower { get; set; }
        public double CubicCapacity { get; set; }

        public Engine(int horsepower, double cubiCapacity)
        {
            this.HorsePower = horsepower;
            this.CubicCapacity = cubiCapacity;
        }
    }
}
