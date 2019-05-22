using System;
namespace _2105
{
    internal class Time: IComparable<Time>
    {
        private int h;
        private int mm;
        private int ss;

        public Time()
        {
            Random rnd = new Random();
            h = rnd.Next(24);
            mm = rnd.Next(60);
            ss = rnd.Next(60);
        }

        public Time(int v1, int v2, int v3)
        {
            this.h = v1;
            this.mm = v2;
            this.ss = v3;
        }

        public int CompareTo(Time other)
        {
            if (other == null)
                return 1;
            if (this.h < other.h)
                return -1;
            else if (this.h > other.h)
                return 1;
            else if (this.mm < other.mm)
                return -1;
            else if (this.mm > other.mm)
                return 1;
            else if (this.ss < other.ss)
                return -1;
            else if (this.ss > other.ss)
                return 1;
            else
                return 0;


        }

        public override string ToString()
        {
            return h + ":" + mm.ToString("D2") + ":" + ss.ToString("D2");
        }
    }
}