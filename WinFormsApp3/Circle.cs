using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    public class Circle : Shape
    {
        private int radius;
        private Point center;

        public Circle(int radius, Point center)
        {
            this.radius = radius;
            this.center = center;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(Pens.Black, center.X - radius, center.Y - radius, 2 * radius, 2 * radius);
        }
    }
}
