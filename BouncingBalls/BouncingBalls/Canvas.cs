using System;
using System.Collections.Generic;
using System.Text;

namespace BouncingBalls
{
    internal class Canvas
    {
        private readonly int MINRADIUS = 3;
        private readonly int MAXRADIUS = 25;

        private readonly int MINSPEED = 1;
        private readonly int MAXSPEED = 10;


        private int width;
        private int height;
        private List<BouncingBall> balls = new List<BouncingBall>();
        private BlackHole bh;
        public Canvas(int noOfBalls, int width, int height)
        {
            this.width = width;
            this.height = height;
            Random rnd = new Random();

            bh = new BlackHole(
                rnd.Next(width), 
                rnd.Next(height), 
                rnd.Next(MINRADIUS, MAXRADIUS));

            for (int i = 0; i < noOfBalls; i++)
            {
                balls.Add(
                    new BouncingBall(
                        rnd.Next(width), 
                        rnd.Next(height), 
                        rnd.Next(MINRADIUS, MAXRADIUS), 
                        rnd.Next(MINSPEED, MAXSPEED), 
                        rnd.Next(MINSPEED, MAXSPEED)));
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(bh);
            sb.Append(Environment.NewLine);

            foreach (var item in balls)
            {
                sb.Append(item);
                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }
    }
}