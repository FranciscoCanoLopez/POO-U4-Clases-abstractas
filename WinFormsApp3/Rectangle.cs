using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    public class Rectangle : Shape
    {
        private int width;
        private int height;
        private Point origin;

        public Rectangle(int width, int height, Point origin)
        {
            this.width = width;
            this.height = height;
            this.origin = origin;
        }

        public override double CalculateArea()
        {
            return width * height;
        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.Black, origin.X, origin.Y, width, height);
        }
    }
}
