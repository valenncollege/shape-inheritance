using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeInheritance
{
    [Serializable]
    public class Rectangle : Shape
    {
        private int width;
        private int height;

        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }

        public Rectangle(int left, int top, int width, int height):base(left, top)
        {
            this.Width = width;
            this.Height = height;
        }

        public override string Display()
        {
            string data = "Rectangle : " + "\n" + base.Display() +
                "Width : " + this.Width + "\n" +
                "Height : " + this.Height + "\n";
            return data;
        }

        public override double CalculateArea()
        {
            return this.Height * this.Width;
        }

        public override double CalculatePerimeter()
        {
            double kel = 2 * (this.Height) + 2 * (this.Width);
            return kel;
        }

        public override double CalculateDiagonal()
        {
            double diag = Math.Sqrt((this.Width * this.Width) + (this.Height * this.Height));
            return diag;
        }
        public override bool IsEquel(Shape obj)
        {
            if (obj is Rectangle)
            {
                if (this.Height == (obj as Rectangle).Height && this.Width == (obj as Rectangle).Width 
                    && base.IsEquel(obj))
                    return true;
                else
                    return false;
            }
            return false;
        }
    }
}