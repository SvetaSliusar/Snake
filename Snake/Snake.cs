using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        public Direction d;
        public Snake(Point tail, int length, Direction d)
        {
            this.d = d;
            
            line = new List<Point>();
            for (int i=0; i<length; i++)
            {
                Point point = new Point(tail);
                point.Move(i, d);
                line.Add(point);
                point.Draw();
            }
        }

        public void Move()
        {
            Point tail = line.First();
            line.Remove(tail);
            Point newHead = GetNewHead(line.Last());
            line.Add(newHead);
            tail.Clear();
            newHead.Draw();
        }

        public Point GetNewHead(Point head)
        {
            Point newHead = new Point(head);
            newHead.Move(1, d);
            return newHead;
        }

        
        public void keyHandler(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                d = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                d = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                d = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                d = Direction.UP;
        }

        public bool Eat(Point food)
        {
            Point head = GetNewHead(line.Last());
            if (head.Equals(food))
            {
                food.symbol = head.symbol;
                food.Draw();
                line.Add(food);
                return true;
            }
            return false;
        }
    }
}