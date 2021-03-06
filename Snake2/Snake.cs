﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class Snake : Figure
    {
        Directions direction;

        public Snake (Point tail, int lenght, Directions _direction)
        {
            direction = _direction;
            pList = new List<Point>();

            for (int i=0; i<lenght; i++)
            {                
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point oldTail = new Point(pList.First());
            pList.Remove(pList.First());

            Point newHead = GetNextPoint();
            pList.Add(newHead);

            oldTail.Clear();
            newHead.Draw();

        }

        private Point GetNextPoint()
        {
            Point p = new Point (pList.Last());
            p.Move(1, direction);
            return p;
        }

        public Point GetHead()
        {
            return (pList.Last());            
        }

        public void KeyHandle(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Directions.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Directions.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Directions.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Directions.UP;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                food.Draw();
                pList.Add(food);
                return true;
            }
            else
                return false;
        }

        public override bool IsHit(Point target)
        {
            for (int i = 0; i<pList.Count()-1; i++)                  
            {
                if (pList[i].IsHit(target))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
