using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class Figure
    {
        protected List<Point> pList;

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        public virtual bool IsHit(Point target)
        {
            foreach (Point p in pList)
            {
                if (p.IsHit(target))
                {
                    return true;                    
                }                    
            }
            return false;
        }
    }
}
