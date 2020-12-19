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
        private Random rand = new Random();
        public Snake Snake { get; set; }

        //public Food[] MyProperty { get; set; }
        public GameEngine()
        {
            Snake = new Snake(new Possition(30, 20));
            gameItems.Add(Snake);
            for (int i = 0; i <20 ; i++)
            {
                var food = new Food
                    (new Possition(rand.Next(0, Console.BufferWidth), 
                    rand.Next(0, Console.WindowHeight)));
                gameItems.Add(food);
            }
        }

        

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
                
                Thread.Sleep(40);
                //Console.Clear();
                gameItems.ForEach(i => i.Draw());
                
            }
        }

        public void Stop()
        {
            isStarted = false;
        }
    }
}
