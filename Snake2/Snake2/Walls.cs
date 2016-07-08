using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class Walls
    {
        List<Figure> wallList=new List<Figure>();
        public Walls(int MapWidth, int MapHeight)
        {
            //отрисовываем рамочку
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rigthLine = new VerticalLine(0, 24, 78, '+');
           
            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rigthLine);
        }

        public  void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();   
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if(wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
