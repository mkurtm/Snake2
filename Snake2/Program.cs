using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point p1 = new Point(1, 3, '*');
            //Point p2 = new Point(11, 3, '&');      
            //p1.Draw();
            //p2.Draw();

            //HorizontalLine hline = new HorizontalLine(3,10,10,'#');
            //hline.Draw();

            //VerticalLine vLine = new VerticalLine(5, 2, 10, '*');
            //vLine.Draw();

            Console.SetBufferSize(80, 25);

            HorizontalLine hLineUp = new HorizontalLine(1, 9, 1, '*');
            HorizontalLine hLineDown = new HorizontalLine(1, 9, 9, '*');
            VerticalLine vLineLeft = new VerticalLine(1, 1, 9, '*');
            VerticalLine vLineRight = new VerticalLine(9, 1, 9, '*');

            hLineDown.Draw();
            hLineUp.Draw();
            vLineLeft.Draw();
            vLineRight.Draw();


            Employee Ivan = new Employee();
            Ivan.salary = 10000;
            Ivan.age = 20;
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("Aaaaa " + Ivan.age + "sasas " + Ivan.salary);




                
            Console.ReadLine();          
        }

        
    }
}
