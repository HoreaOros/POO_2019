using System.Text;
namespace BouncingBalls
{
    internal class BouncingBall: Ball
    {
        private int speedx, speedy;

        public BouncingBall(int x, int y, int r, int sx, int sy): base(x, y, r)
        {
            speedx = sx;
            speedy = sy;
        }

        public int SpeedX
        {
            get
            {
                return speedx;
            }
        }
        public int SpeedY
        {
            get
            {
                return speedy;
            }
        }
        public void BounceXSpeed()
        {
            speedx = -speedx;
        }
        public void BounceYSpeed()
        {
            speedy = -speedy;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Boucing Ball: [");
            sb.AppendFormat("({0}, {1}) - R = {2} - Speed = ({3}, {4})", X, Y, R, speedx, speedy);
            sb.Append("]");

            return sb.ToString();
        }
    }

    
}