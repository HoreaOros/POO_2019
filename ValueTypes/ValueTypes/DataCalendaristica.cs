using System;
using HelperTypes;

namespace ValueTypes
{
    struct DataCalendaristica
    {
        int zi, an;
        Luna luna;

        public DataCalendaristica(int z, Luna l, int a)
        {
            zi = z;
            luna = l;
            an = a;
        }

        public void Print()
        {
            Console.WriteLine("{0}-{1}-{2}", zi, luna, an);
        }
    }
}