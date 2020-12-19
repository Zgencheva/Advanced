using GameSnake.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSnake
{
    public class Food : IDrawable
    {
        public Food(Possition possition, char symbol = '#')
        {
            this.Symbol = symbol;
            this.Possition = possition;
        }
        public Possition Possition { get; set; }
        public char Symbol { get; set; }

        public void Draw()
        {

            Console.SetCursorPosition(Possition.X, Possition.Y);
            Console.WriteLine(Symbol);

        }
    }
}
