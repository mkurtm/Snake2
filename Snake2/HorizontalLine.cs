using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class HorizontalLine
    {
        List<Point> pList;

    public HorizontalLine(int xStart, int xEnd, int y, char sym)
        {
            pList = new List<Point>();
            
            for (int x=xStart; x<=xEnd; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
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
