using System;
using System.Collections.Generic;
using System.Text;

namespace GameSnake
{
    public class Possition
    {
        public Possition(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }

        public void ChangePossition(Possition possition)
        {
            this.X += possition.X;
            this.Y += possition.Y;

        }
        

    }
}
