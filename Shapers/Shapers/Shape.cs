using System;
using System.Collections.Generic;
using System.Text;

namespace Shapers
{
    enum Color
    {
        Red,
        Yellow,
        Blue,
        Green,
        Pink,
        Purple
    }
    abstract class Shape
    {
        protected Color color;
        protected bool filled;

        public Shape():this(Color.Pink,false)
        {
        }
        public Shape(Color color,bool filled)
        {
            this.color = color;
            this.filled = filled;
        }
        public Color getColor()
        {
            return color;
        }
        public void setColor(Color color)
        {
            this.color = color;
        }
        public bool isFilled()
        {
            return filled;
        }
        public void setFilled(bool filled)
        {
            this.filled = filled;
        }
        public abstract double getArea();

        public abstract double getPerimeter();

        
    }


}
