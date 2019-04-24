using System;
using System.Threading;
namespace BouncingBalls
{
    internal class Game
    {
        private int balls;
        private int width, height;
        private Canvas c;
        public Game(int v): this(v, 800, 600)
        {
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="v">No. of balls</param>
        /// <param name="v1">Width</param>
        /// <param name="v2">Height</param>
        public Game(int v, int v1, int v2)
        {
            this.width = v1;
            this.height = v2;
            this.balls = v;
            c = new Canvas(balls, width, height);
        }
        internal void Status()
        {
            Console.WriteLine("Status...");
            Console.WriteLine(c);
        }

        internal void Play()
        {
            while (true)
            {
                c.Step();
                Thread.Sleep(1000);
            }
        }

       
    }
}