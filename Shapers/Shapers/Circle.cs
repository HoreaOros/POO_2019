using System;
using System.Collections.Generic;
using System.Text;

namespace Shapers
{
    class Circle : Shape
    {
        private double radius;

        public Circle():this(1)
        { }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle(double radius, Color color, bool filled) : base(color, filled)
        {
            this.radius = radius;
        }
        
        public double Radius
        {
            get { return radius; }
            set
            {
                if(value>0)
                    radius = value;
            }
        }
        public override double getArea()
        {
            return radius * radius * Math.PI;
        }

        public override double getPerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override string ToString()
        {
            return String.Format("[Circle, radius = {0}, color = {1}" +
                ",filled = {2}]",radius,color,filled);
        }
    }
}
