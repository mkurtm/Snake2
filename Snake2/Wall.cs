using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class Wall
    {
      
        List<Figure> fList;

        public Wall(int width, int height, char sym)
        {
            fList = new List<Figure>();

            HorizontalLine hLineUp = new HorizontalLine(0, width-2, 0, sym);
            HorizontalLine hLineDown = new HorizontalLine(0, width-2, height-2, sym);
            VerticalLine vLineLeft = new VerticalLine(0, 0, height-2, sym);
            VerticalLine vLineRight = new VerticalLine(width-2, 0, height-2, sym);

            fList.Add(hLineDown);
            fList.Add(hLineUp);
            fList.Add(vLineLeft);
            fList.Add(vLineRight);            
        }

        public void Draw()
        {
            foreach (var f in fList)
            {
                f.Draw();
            }
        }

        public bool IsHit (Point head)
        {
            foreach (Figure f in fList)
            {
                if (f.IsHit(head))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
