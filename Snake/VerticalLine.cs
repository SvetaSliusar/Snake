using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int x, int yTop, int yLow, char symbol)
        {
            line = new List<Point>();
            for (int i = yTop; i <= yLow; i++)
            {
                Point p = new Point(x, i, symbol);
                line.Add(p);
            }
        }
      
    }
}
