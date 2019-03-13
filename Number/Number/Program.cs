using System;

namespace Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Numar n = new Numar(12764787846358441471);

            Console.WriteLine("Suma cifrelor numarului {0} este {1}", n.Value, n.SumaCifre());

            Console.WriteLine("Numarul {0} {1}este prim", n.Value, n.EstePrim()?"":"nu ");

            Console.WriteLine("Numarul {0} are {1} divizori", n.Value, n.NumarDivizori2);

            Console.WriteLine("Suma divizorilor numarului {0} este {1}", n.Value, n.SumaDivizori);
        }
    }
}
