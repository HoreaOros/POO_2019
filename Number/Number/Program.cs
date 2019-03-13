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

            // TODO
            // n.Hex; // intoarce un string ce reprezinta valoarea hexazecimala a numarului
            // n.ConvertToBase(7); // intoarce un string cu reprezentarea numarului in baza tinta (2->16). 

            // n1.Add(n2); // intoarce un obiect de tip "Numar" care are ca si valoarea suma celor doua numere
            // si restul operatiilor aritmetice similar ^^
        }
    }
}
