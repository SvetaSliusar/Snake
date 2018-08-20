using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int height;
        int width;
        char sym;
        public FoodCreator(int height, int width, char sym)
        {
            this.height = height;
            this.width = width;
            this.sym = sym;
        }

        public Point getFood()
        {
            Random ran = new Random();
            int x = ran.Next(2, width - 2);
            int y = ran.Next(2, height - 2);
            return new Point(x, y, sym);
        }
    }
}
