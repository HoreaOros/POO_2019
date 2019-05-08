using System;
using System.Collections.Generic;
using System.Text;

namespace Shapers
{
    class Rectangle : Shape
    {
        protected double width;
        protected double length;

        public Rectangle() { } 
        public Rectangle(double width,double length)
        {
            this.width = width;
            this.length = length;
        }
        public Rectangle(double width,double length,Color color,
            bool filled):base(color,filled)
        {
            this.width = width;
            this.length = length;
        }

        public double Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                    width = value;
            }
        }
        public double Length
        {
            get { return length; }
            set
            {
                if (value > 0)
                    length = value;
            }
        }

        public override double getArea()
        {
            return width * length;
        }

        public override double getPerimeter()
        {
            return 2 * (length + width);
        }

        public override string ToString()
        {
            return String.Format("[Rectangle, width={0}, length={1}, color={2}, filled={3}]",
                width, length, color, filled);
        }
    }
}
