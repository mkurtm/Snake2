using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake2
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizontalLine hl = new HorizontalLine(5, 10, 5, '*');
            Draw(hl);

            Point p = new Point(8, 8, '@');
            Figure fSnake = new Snake(p, 4, Directions.RIGHT);
            fSnake.Draw();
            Snake snake = (Snake)fSnake;

            VerticalLine vl = new VerticalLine(10, 2, 7, '#');
            Draw(vl);

            Thread.Sleep(3000);
            Console.ReadLine();
            Console.Clear();
            Thread.Sleep(3000);

            List<Figure> figures = new List<Figure>();
            figures.Add(hl);
            figures.Add(fSnake);
            figures.Add(snake);
            figures.Add(vl);

            foreach (var f in figures)
            {
                f.Draw();
            }

            Console.ReadLine();      
        }

        private static void Draw(Figure figure)
        {
            figure.Draw();
        }
    }
}
