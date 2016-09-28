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
            int X = Convert.ToInt32(Console.ReadLine());
            int Y = Convert.ToInt32(Console.ReadLine());
            char S = '#';
            Draw(X, Y, S);
            Console.ReadKey();
        }

         static void Draw (int x, int y, char s)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(s);

        }
    }
}
