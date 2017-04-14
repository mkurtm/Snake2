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
            Console.SetBufferSize(80, 25);

            //Создаем и отрисовываем стены

            Wall wall = new Wall(80, 25, '+');
            wall.Draw();

            //Snake drawing

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Directions.RIGHT);
            snake.Draw();

            //Make food

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();



            while (true)
            {
                //Делаем проверку на пересечение головы и стены либо тела змеики
                Point head = new Point(snake.GetHead());

                if (wall.IsHit(head) || snake.IsHit(head))
                {
                    Console.Clear();
                    Console.WriteLine("Game over");
                    Thread.Sleep(3000);
                    break;
                }

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
