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

            HorizontalLine hLineUp = new HorizontalLine(1, 79, 1, '*');
            HorizontalLine hLineDown = new HorizontalLine(1, 79, 22, '*');
            VerticalLine vLineLeft = new VerticalLine(1, 1, 22, '*');
            VerticalLine vLineRight = new VerticalLine(79, 1, 22, '*');

            hLineDown.Draw();
            hLineUp.Draw();
            vLineLeft.Draw();
            vLineRight.Draw();

            //Snake drawing

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Directions.RIGHT);
            snake.Draw();

            //Snake moving

            //Make food

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();


            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.KeyHandle(key.Key);                    
                }
                
            }            
                  
        }        
    }
}
