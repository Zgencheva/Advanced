using GameSnake.Helpers;
using GameSnake.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSnake
{
    class Snake : IDrawable
    {
        public Snake(Possition headPossition)
        {
            SnakeBody = new LinkedList();
            SnakeBody.AddHead(new Node(headPossition));
            //this.Head = new Node(headPossition);
            for (int i = 0; i < 10; i++)
            {
                SnakeBody.AddLast(new Node
                    (new Possition(headPossition.X + i, headPossition.Y)));
            }
        }
        public LinkedList SnakeBody { get; set; }
        public List<Food> Foods { get; set; }
        //public Node Head { get; set; }

        public void Draw()
        {
            SnakeBody.ForEach(n =>
            {
                var text = "*";


                if (n == SnakeBody.Head)
                {
                    text = "@";
                }
                ConsoleHelper.Write(n.Value, text);

            }

                );

        }

        public void Move(Possition position)
        {
            if (position.X == 0 && position.Y == 0)
            {
                return;
            }

            ConsoleHelper.Clear(SnakeBody.Tail.Value);

            SnakeBody.ReverseForEach(n =>
           {

               if (n.Previous != null)
               {
                   n.Value.X = n.Previous.Value.X;
                   n.Value.Y = n.Previous.Value.Y;
               }
           });
            SnakeBody.Head.Value.ChangePossition(position);

            for (int i = 0; i < Foods.Count; i++)
            {
                if (Foods[i].Possition == SnakeBody.Head.Value)
                {

                }
            }
        }


    }
}
