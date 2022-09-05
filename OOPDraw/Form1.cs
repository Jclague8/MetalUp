using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPDraw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            LineWidth.SelectedItem = "Thin";
            Colour_Box.SelectedItem = "Black";
            comboBox1.SelectedItem = "Line";

        }

        Pen currentPen = new Pen(Color.Black);
        bool dragging = false;
        Point startOfDrag = Point.Empty;
        Point lastMousePosition = Point.Empty;
        private List<Shape> shapes = new List<Shape>(); 

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            foreach (Shape shape in shapes)
            {
                shape.Draw(gr);
            }
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startOfDrag = lastMousePosition = e.Location;
            switch (comboBox1.Text)
            {
                case "Line":
                    shapes.Add(new Line(currentPen, e.X, e.Y));
                    break;
                case "Rectangle":
                    shapes.Add(new Rectangle(currentPen, e.X, e.Y));
                    break;
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Shape shape = shapes.Last();
                shape.GrowTo(e.X, e.Y);
                lastMousePosition = e.Location;
                Refresh();
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            
        }

        private void LineWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            float width = currentPen.Width;
            switch (LineWidth.Text)
            {
                case "Thin":
                    width = 2.0F;
                    break;
                case "Medium":
                    width = 4.0F;
                    break;
                case "Thick":
                    width = 6.0F;
                    break;
            }
            currentPen = new Pen(currentPen.Color, width);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Colour_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color colour = currentPen.Color;
            switch (Colour_Box.Text)
            {
                case "Black":
                    colour = Color.Black;
                    break;
                case "Red":
                    colour = Color.Red;
                    break;
                case "Blue":
                    colour = Color.Blue;
                    break;
                case "Green":
                    colour = Color.Green;
                    break;
                case "Yellow":
                    colour = Color.Yellow;
                    break;
                case "Purple":
                    colour = Color.Purple;
                    break;
            }
            currentPen = new Pen(colour, currentPen.Width);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
