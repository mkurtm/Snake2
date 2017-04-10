using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class FoodCreator
    {
        private int xmax;
        private int ymax;
        private char sym;

        Random random = new Random();

        public FoodCreator(int xmax, int ymax, char sym)
        {
            this.xmax = xmax;
            this.ymax = ymax;
            this.sym = sym;                     
        
        }

        public Point CreateFood()
        {
            int x = random.Next(xmax);
            int y = random.Next(ymax);
            return new Point(x, y, sym);
        }
    }
}
