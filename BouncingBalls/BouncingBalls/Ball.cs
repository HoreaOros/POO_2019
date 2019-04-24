using System.Text;
using System;

namespace BouncingBalls
{
    internal abstract class Ball
    {
        private int x, y;
        private int raza;
        
        
        public Ball(int x, int y, int raza)
        {
            this.x = x;
            this.y = y;
            this.raza = raza;
            
        }
        

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public int R
        {
            get
            {
                return raza;
            }
            set
            {
                raza = value;
            }
        }
        
        public bool CheckCollision(Ball b2)
        {
            double dist;

            dist = Math.Sqrt(Math.Pow(x - b2.X, 2) + Math.Pow(y - b2.Y, 2));
            return (dist <= R + b2.R);
        }
    }
}