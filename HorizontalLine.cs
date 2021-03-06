﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for(int x = xLeft; x <= xRight; x++)
            {
                pList.Add(new Point(x, y, sym));
            }
        }
        /*public override void Draw()
        {
            var col = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            base.Draw();
            Console.ForegroundColor = col;
        }*/
    }
}
