using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int x, int yStart, int yEnd, char sym)
        {
            pList = new List<Point>();

            for (int y = yStart; y<= yEnd; y++)
            {
                pList.Add(new Point(x, y, sym));

            }

        }

        public void Draw()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
