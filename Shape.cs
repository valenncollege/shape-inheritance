using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeInheritance
{
    [Serializable]
    public class Shape
    {
        private int left;
        private int top;

        public int Left { get => left; set => left = value; }
        public int Top { get => top; set => top = value; }

        public Shape(int left, int top)
        {
            this.Left = left;
            this.Top = top;
        }

        public string Display()
        {
            string data = "Left : " + this.Left + "\n" +
                "Top : " + this.Top + "\n";
            return data;
        }
    }
}