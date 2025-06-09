using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeInheritance
{
    [Serializable]
    public abstract class Shape
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

        public virtual string Display()
        {
            string data = "Left : " + this.Left + "\n" +
                "Top : " + this.Top + "\n";
            return data;
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();

        public abstract double CalculateDiagonal();

        public virtual bool IsEquel(Shape obj)
        {
            if (this.Left == (obj as Shape).Left && this.Top == (obj as Shape).Top)
                return true;
            else
                return false;
        }
    }
}