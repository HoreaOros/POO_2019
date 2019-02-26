using System;
namespace Bars
{
    internal class VertBar
    {
        private int inaltime;

        public VertBar(int v)
        {
            this.inaltime = v;
            for (int i = 0; i < inaltime; i++)
            {
                Console.WriteLine("|");
            }
        }

        public int Inaltime
        {
            get
            {
                return inaltime;
            }
         }
    }
}