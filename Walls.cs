using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;
        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
            HorizontalLine hlTop = new HorizontalLine(0, mapWidth - 1, 0, '+');
            HorizontalLine hlBottom = new HorizontalLine(0, mapWidth - 1, mapHeight - 2, '+');
            VerticalLine vlLeft = new VerticalLine(0, 0, mapHeight - 2, '+');
            VerticalLine vlRight = new VerticalLine(mapWidth - 1, 0, mapHeight - 2, '+');
            wallList.Add(hlTop);
            wallList.Add(hlBottom);
            wallList.Add(vlLeft);
            wallList.Add(vlRight);
        }
        public bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if (wall.IsHit(figure))
                    return true;
            }
            return false;
        }
        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
