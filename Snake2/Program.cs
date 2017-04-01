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
            int x = 1, y = 3;
            char a = '*';
            Draw(x, y, a);
            Draw(x + 1, y + 1, a);
            Draw(x + 12, y + 11, a);





            Console.ReadLine();

        

           
        }

        static void Draw (int x , int y, char a)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(a);
        }
    }
}
