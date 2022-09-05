using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace OOPDraw
{
    class Rectangle : Shape
    {
        public Rectangle(Pen p, int x1, int y1, int x2, int y2) // constructor to assign values to protected variables
        {
            Pen = p;
            X1 = x1;
            X2 = x2;
            Y1 = y1;
            Y2 = y2;
        }

        public Rectangle(Pen p, int x1, int y1) : this(p, x1, y1, x1, y1) // overload constructor
        { 
        }

        public override void Draw(Graphics g) // Finds the origin point for the rectangle allowing it to be drawn in any direction
        {
            int x = Math.Min(X1, X2);
            int y = Math.Min(Y1, Y2);
            int w = Math.Max(X1, X2) - x;
            int h = Math.Max(Y1, Y2) - y;
            g.DrawRectangle(Pen, x, y, w, h);
        }



    }
}
