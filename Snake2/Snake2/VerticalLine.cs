﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class VerticalLine
    {
               List<Point> pList;
               public VerticalLine(int yLeft, int yRight, int x, char sym)
        {
            pList = new List<Point>();
            for (int i=yLeft;i<=yRight;i++)
            {
                Point p = new Point(x, i, sym);
                pList.Add(p);
            }
        }

        public void Draw()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}