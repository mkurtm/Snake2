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
            
            //Отрисовка Рамки

            Console.SetBufferSize(80, 25);

            HorizontalLine hLineUp = new HorizontalLine(1, 9, 1, '*');
            HorizontalLine hLineDown = new HorizontalLine(1, 9, 9, '*');
            VerticalLine vLineLeft = new VerticalLine(1, 1, 9, '*');
            VerticalLine vLineRight = new VerticalLine(9, 1, 9, '*');

            hLineDown.Draw();
            hLineUp.Draw();
            vLineLeft.Draw();
            vLineRight.Draw();

            //Snake drawing
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Directions.RIGHT);
            snake.Draw();

            //Snake moving
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.KeyHandle(key.Key);                    
                }
                Thread.Sleep(100);
                snake.Move();
            }            
                  
        }        
    }
}
