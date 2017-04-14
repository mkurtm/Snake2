using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class VerticalLine : Figure
    {
        
        public VerticalLine(int x, int yStart, int yEnd, char sym)
        {
            pList = new List<Point>();

            for (int y = yStart; y<= yEnd; y++)
            {
                pList.Add(new Point(x, y, sym));

            }

        }
        
    }
}
