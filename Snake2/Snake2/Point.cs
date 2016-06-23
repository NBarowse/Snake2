using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        {

        }
        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }


        public static void Move(Point p, int dx, int dy)
        {
            p.x = p.x + dx;
            p.y = p.y + dy;
        }
        public static void Reset(Point p)
        {
            p = new Point();
        }
    }
}
