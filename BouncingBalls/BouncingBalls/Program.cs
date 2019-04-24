using System;

namespace BouncingBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game(25, 1024, 768);

            g.Play();

            g.Status();
        }
    }
}
