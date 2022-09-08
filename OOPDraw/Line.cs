using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace OOPDraw
{
    public class Line : Shape
    {
        
        public Line(Pen p, int x1, int y1, int x2, int y2) : base(p,x1,y1,x2,y2) // constructor to assign values to protected variables
        {
            Pen = p;
            X1 = x1;
            X2 = x2;
            Y1 = y1;
            Y2 = y2;
        }

        public Line(Pen p, int x1, int y1) : base(p, x1, y1) // overload constructor
        { 
        }

        public override void Draw(Graphics g) // draws a line using the 4 coordinates given
        {
            g.DrawLine(Pen, X1, Y1, X2, Y2);
        }


    }
}
