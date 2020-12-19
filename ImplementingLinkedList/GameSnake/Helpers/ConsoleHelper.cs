using System;
using System.Collections.Generic;
using System.Text;

namespace GameSnake.Helpers
{
    class ConsoleHelper
    {
        public static void Clear(Possition position)
        {
            Console.SetCursorPosition(position.X, position.Y);
            
                Console.Write(" ");
            
        }

        public static void Write(Possition position, string text)
        {
            Console.SetCursorPosition(position.X, position.Y);

            Console.Write(text);

        }
    }
}
