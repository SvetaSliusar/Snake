using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> walls = new List<Figure>();

        public Walls(int width, int height)
        {
            HorizontalLine line = new HorizontalLine(0, width - 2, 0, '*');
            HorizontalLine line2 = new HorizontalLine(0, width-2, height-1, '*');
            VerticalLine line3 = new VerticalLine(0, 1, height-2, '*');
            VerticalLine line4 = new VerticalLine(width-2, 1, height-2, '*');
            walls.Add(line); walls.Add(line2); walls.Add(line3); walls.Add(line4);
        }
        
        public void Draw()
        {
            foreach (Figure wall in walls)
            {
                wall.Draw();
            }
        }
        public bool isStrike(Snake snake)
        {
            Figure wall = new Figure();
            if (snake.d == Direction.UP)
                wall = walls[0];
            else
                if (snake.d == Direction.DOWN)
                wall = walls[1];
            else
                if (snake.d == Direction.LEFT)
                wall = walls[2];
            else
                if (snake.d == Direction.RIGHT)
                wall = walls[3];
            //foreach(Figure wall in walls)
            //{
                foreach (Point p in wall.line)
                {
                    if (p.Equals(snake.line.Last())) 
                        return true;
                }
            //}
            return false;
        }
    }
}
