using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()

        {
            Console.WriteLine("Waiting");
        }

        public Point (int  _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int Offset, Directions direction)
        {
            if (direction == Directions.RIGHT)
            {
                x = x + Offset;
            }
            else if (direction == Directions.LEFT)
            {
                x = x - Offset;
            }
            else if (direction == Directions.UP)
            {
                y = y - Offset;
            }
            else if (direction == Directions.DOWN)
            {
                y = y + Offset;
            }


        }

        internal void Clear()
        {
            sym = ' ';
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }

        internal bool IsHit(Point p)
        {
            return p.x == this.x && this.y == p.y;
        }
    }

  
}
