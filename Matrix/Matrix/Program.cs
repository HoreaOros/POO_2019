using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix m1 = new Matrix(3, 4);
            Matrix m2 = new Matrix(4, 5);

            Matrix m3 = new Matrix(6);

            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);

            m1.RandomInit(1000);
            Console.WriteLine(m1);

            m2.RandomInit(1000);
            Console.WriteLine(m2);

            m3.RandomInit(1000000);
            Console.WriteLine(m3);

            Matrix p = m1 * m2;
            Console.WriteLine(p);


        }
    }
}
