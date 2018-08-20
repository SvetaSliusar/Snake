using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char symbol;

        public Point(Point point)
        {
            x = point.x;
            y = point.y;
            symbol = point.symbol;
        }

        public override bool Equals(object obj)
        {
            Point point = obj as Point;
            if (point.x==x && point.y ==y)
            {
                return true;
            }
            return false;
        }
        public Point(int x, int y, char symbol)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
        
        public void Clear()
        {
            symbol = ' ';
            Draw();
        }
        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.DOWN)
                y += offset;
            else if (direction == Direction.LEFT)
                x -= offset;
            else if (direction == Direction.RIGHT)
                x += offset;
            else if (direction == Direction.UP)
                y -= offset;
        }
    }
}
