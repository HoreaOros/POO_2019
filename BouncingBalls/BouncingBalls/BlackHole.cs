using System;
using System.Text;

namespace BouncingBalls
{
    internal class BlackHole : Ball
    {
        public override bool Exists()
        {
            return true;
        }
        public BlackHole(int x, int y, int r): base(x, y, r)
        {
            
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Black Hole: [");
            sb.AppendFormat("({0}, {1}) - R = {2}", X, Y, R);
            sb.Append("]");

            return sb.ToString();
        }
    }
}