using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeInheritance
{
    [Serializable]
    public class Circle : Shape
    {
        private int diameter;

        public int Diameter { get => diameter; set => diameter = value; }

        public Circle(int left, int top, int diameter):base(left, top)
        {
            this.Diameter = diameter;
        }

        public override string Display()
        {
            string data = "Circle " + "\n" + base.Display()+
                "Diameter : " + this.Diameter + "\n";
            return data;
        }

        public override double CalculateArea()
        {
            double luas = Math.PI * (this.Diameter / 2.0) * (this.Diameter / 2.0);
            return luas;
        }

        public override double CalculatePerimeter()
        {
            double kel = Math.PI * this.Diameter;
            return kel;
        }
    }
}