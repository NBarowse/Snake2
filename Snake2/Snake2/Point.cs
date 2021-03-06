﻿using System;
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
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public void Move(int offset, DIrection direction)
        {
            if (direction == DIrection.Right)
                x = x + offset;
            else if (direction == DIrection.Left)
                x = x - offset;
            else if (direction == DIrection.Up)
                y = y - offset;
            else if (direction == DIrection.Down)
                y = y + offset;
        }
        public void Clear()
        {            
            sym = ' ';
            Draw();
        }

        public bool IsHit(Point p)
        {
            return  p.x==this.x &&  p.y==this.y;
        }
        public override string ToString()
        {
            return x+", " + y + ", " + sym;
        }

    }
}
