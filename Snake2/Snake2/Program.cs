﻿using System;
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

            Console.SetBufferSize(80, 25); //устанавливаем границы консоли

            //отрисовываем рамочку
            HorizontalLine upLine = new HorizontalLine(0,78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rigthLine = new VerticalLine(0, 24, 78, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rigthLine.Draw();       
            
            //создаем точку
            Point p = new Point(4, 5, '*');
            p.Draw();

        }
    }
}