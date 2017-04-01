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
            Point p1 = new Point()
            {
                x = 1,
                y = 3,
                sym = '*'
            };

            Point p2 = new Point()
            {
                x = 11,
                y = 13,
                sym = '*'
            };


            p1.Draw();
            p2.Draw();



            Console.ReadLine();          
        }

        
    }
}
