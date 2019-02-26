using System;
namespace Bars
{
    internal class HorzBar
    {
        int lungime;
        public HorzBar(int lungime)
        {
            this.lungime = lungime;
            Console.Write("+");
            for (int i = 0; i < lungime; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }

        public int Lungime
        {
            get
            {
                return lungime;
            }
        }
    }
}