namespace Bars
{
    internal class Frame
    {
        HorzBar h1, h2;
        VertBar v;

        public Frame(int latime, int inaltime)
        {
            h1 = new HorzBar(latime);
            v = new VertBar(inaltime);
            h2 = new HorzBar(latime);
        }
    }
}