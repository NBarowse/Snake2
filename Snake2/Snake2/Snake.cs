using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class Snake:Figure
    {
        DIrection direction;
        public Snake(Point tail, int length, DIrection _direction )
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i=0; i<length;i++)
            {
            Point p = new Point(tail);
            p.Move(i,_direction);
            pList.Add(p);
            }


        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();  
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }
        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point NextPoint = new Point(head);
            NextPoint.Move(1, direction);
            return NextPoint;
        }

        internal void HandleKey(ConsoleKey consoleKey)
        {
            if (consoleKey == ConsoleKey.LeftArrow)
                direction = DIrection.Left;
            else if (consoleKey == ConsoleKey.RightArrow)
                direction = DIrection.Right;
            else if (consoleKey == ConsoleKey.UpArrow)
                direction = DIrection.Up;
            else if (consoleKey == ConsoleKey.DownArrow)
                direction = DIrection.Down;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
                return false;
        }
    }
}
