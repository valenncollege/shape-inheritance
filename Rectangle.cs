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

        public string Display()
        {
            string data = "Rectangle : " + "\n" + base.Display() +
                "Width : " + this.Width + "\n" +
                "Height : " + this.Height + "\n";
            return data;
        }
    }
}