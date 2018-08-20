using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        public List<Point> line;
        public void Draw()
        {
            foreach (var p in line)
            {
                p.Draw();
            }
        }
        public bool isStrike()
        {
            for (int i = 0; i < line.Count - 2; i++)
            {
                if (line.Last().Equals(line[i]))
                    return true;
            }
            return false;
        }
    }
}
