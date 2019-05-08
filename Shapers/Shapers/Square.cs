using System;
using System.Collections.Generic;
using System.Text;

namespace Shapers
{
    class Square:Rectangle
    {
        protected double side;

        public Square() { }
        public Square(double side) : base(side, side)
        { }
        public Square(double side,Color color, bool filled):base(side,side,color,filled)
        { }
        public double Side
        {
            get { return side; }
            set
            {
                if (value > 0)
                    width=length=side = value;
            }
        }
        public override string ToString()
        {
            return String.Format("[Square, side={0}, color={1}, filled={2}]",
                width, color, filled);
        }
    }
}
