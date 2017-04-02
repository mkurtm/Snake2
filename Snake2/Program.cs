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

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0);

            List<Point> pointList = new List<Point>();
            pointList.Add(p1);
            pointList.Add(p2);

            foreach(Point p in pointList)
            {
                p.Draw();
            }
            
            Console.ReadLine();          
        }

        
    }
}
