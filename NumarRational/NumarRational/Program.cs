using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumarRational
{
    class Program
    {
        static void Main(string[] args)
        {
            Fractie f1 = new Fractie();
            Fractie f2 = new Fractie(3, 9);

            f1.Print();
            f2.Print();

            Fractie f3 = new Fractie("  4 / 8  ");
            f3.Print();

            Fractie f4;

            f4 = f2.Add(f3);
            f4.Print();

            /** TODO
            f4 = f2.Multiply(f3);
            f4.Print();

            f4 = f2.Subtract(f3);
            f4.Print();

            f4 = f2.Divide(f3);
            f4.Print();
            */

        }
    }
}
