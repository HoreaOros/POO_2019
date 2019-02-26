namespace Bars
{
    internal class Ladder
    {
        Frame f1, f2;
        VertBar v;

        public Ladder(int v1, int v2, int v3)
        {
            f1 = new Frame(v1, v2);
            v = new VertBar(v3);
            f2 = new Frame(v1, v2);
        }
    }
}