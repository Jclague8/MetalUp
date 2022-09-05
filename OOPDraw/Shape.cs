using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace OOPDraw
{
    public abstract class Shape
    {
        public Pen Pen { get; protected set; }
        public int X1 { get; protected set; }
        public int X2 { get; protected set; }
        public int Y1 { get; protected set; }
        public int Y2 { get; protected set; }

        public abstract void Draw(Graphics g);

        public void GrowTo(int x2, int y2) // used to update the end coordinates of the line being drawn
        {
            X2 = x2;
            Y2 = y2;
        }
    }
}
