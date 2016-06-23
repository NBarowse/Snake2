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
            p1.Draw();


            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

           /* Point p3 = new Point(6, 7, '@');
            Point.Move(p3, 10, 10); //p3 измениться
            Point.Reset(p3); */ //p3 останется без изменений

        }
    }
}
