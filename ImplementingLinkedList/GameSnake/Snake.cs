using GameSnake.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSnake
{
    class Snake:IDrawable
    {
        public Snake(Possition head)
        {
            this.Head = head;
        }
        public Possition Head { get; set; }

        public void Draw()
        {
            Console.SetCursorPosition(Head.X, Head.Y);
            Console.Write("*");
        }

        public void Move(Possition position)
        {
            this.Head.ChangePossition(position);
        }


    }
}
