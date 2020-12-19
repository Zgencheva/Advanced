using GameSnake.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GameSnake
{
    class GameEngine
    {

        bool isStarted = false;

        List<IDrawable> gameItems = new List<IDrawable>();

        public GameEngine()
        {
            Snake = new Snake(new Possition(30, 20));
            gameItems.Add(Snake);
        }

        public Snake Snake { get; set; }

        public void Start()
        {
            isStarted = true;
            Possition movement = new Possition(0,0);
            while (isStarted == true)
            {
                //Console.WriteLine("Playing the game");
                Snake.Move(movement);
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(false).Key;
                    movement = ReadUserInput.GetMovement(key);
                }
                
                Thread.Sleep(50);
                Console.Clear();
                gameItems.ForEach(i => i.Draw());
                
            }
        }

        public void Stop()
        {
            isStarted = false;
        }
    }
}
