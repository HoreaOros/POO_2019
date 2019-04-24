using System.Text;
using System;

namespace BouncingBalls
{
    internal abstract class Ball
    {
        private int x, y;
        private int raza;
        protected bool exists = true;

        public abstract bool Exists();




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

        public void Bang(Ball item)
        {
            int r1, r2;

            r1 = R;
            r2 = item.R;

            R = (int)(Math.Sqrt(Math.Pow(r2, 2) + Math.Pow(r2, 2)));
        }
    }
}