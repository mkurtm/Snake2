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
            Point p1 = new Point(1, 3, '*');
            Point p2 = new Point(11, 3, '&');      
            p1.Draw();
            p2.Draw();

            HorizontalLine hline = new HorizontalLine(3,10,10,'#');
            hline.Draw();

            VerticalLine vLine = new VerticalLine(5, 2, 10, '*');
            vLine.Draw();
                
            Console.ReadLine();          
        }

        
    }
}
