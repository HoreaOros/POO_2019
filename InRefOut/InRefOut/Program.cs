using System;

namespace InRefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // T.SayHello();

            T t1 = new T();
            // t.SayGoodBye();

            T t2 = new T();
            T t3 = new T();

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            t1.id *= 10;
            t2.id *= 10;
            t3.id *= 10;

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            RefByVal(t1);
            Console.WriteLine(t1);

            RefByRef(ref t1);
            Console.WriteLine(t1);

            int n = 666;
            ValByVal(n);
            Console.WriteLine(n);

            ValByRef(ref n);
            Console.WriteLine(n);

        }

        private static void ValByRef(ref int d)
        {
            d = 777;
        }

        private static void ValByVal(int d)
        {
            d = 777;
        }

        private static void RefByRef(ref T t)
        {
            t = new T();
        }

        private static void RefByVal(T t)
        {
            t.id *= 10;

            t = new T();
        }
    }
}
