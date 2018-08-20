using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake
{   
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            Walls w = new Walls(80, 25);
            w.Draw();
            Snake snake = new Snake(new Point(2, 5,'*'), 4, Direction.DOWN);
            FoodCreator foodCreator = new FoodCreator(25,80,'&');
            Point food = foodCreator.getFood();
            food.Draw();
            snake.Draw();
            while (true)
            {                
                if (w.isStrike(snake) || snake.isStrike())
                    break;
                if (snake.Eat(food))
                {
                    food = foodCreator.getFood();
                    food.Draw();
                }
                else
                    snake.Move();
                if (Console.KeyAvailable)
                    snake.keyHandler(Console.ReadKey().Key);
                Thread.Sleep(200);
            }
        }

    }
}
