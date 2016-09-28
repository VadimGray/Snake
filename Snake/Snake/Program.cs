using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point p1 = new Point(1, 3, '#');
            //p1.Draw();

            //Point p2 = new Point(4, 5, '@');
            //p2.Draw();

            Horisontalr_line hl = new Horisontalr_line(3, 10, 5, '#');
            hl.Drow();

            Vertical_Line vl = new Vertical_Line(5, 10, 15, '#');
            vl.Driw();


            Console.ReadKey();

        }
    }
}
