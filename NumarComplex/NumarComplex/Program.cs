using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NumarComplex
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(4, 5);

            

            Complex c2 = new Complex(3, 7);

            Complex c3 = c1 + c2;

            Console.WriteLine(c3);
        }
    }
}
