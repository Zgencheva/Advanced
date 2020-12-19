using System;

namespace GameSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            var engine = new GameEngine();
            engine.Start();


        }
    }
}
