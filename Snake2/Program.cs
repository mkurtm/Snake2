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

            HorizontalLine hLineUp = new HorizontalLine(1, 78, 1, '*');
            HorizontalLine hLineDown = new HorizontalLine(1, 78, 24, '*');
            VerticalLine vLineLeft = new VerticalLine(1, 1, 24, '*');
            VerticalLine vLineRight = new VerticalLine(78, 1, 24, '*');

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
                FoodCreator food = new FoodCreator(80, 25, '$');




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
