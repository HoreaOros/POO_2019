using System;
using System.Threading;
namespace _904
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DateTime dt = DateTime.Now;


            Console.WriteLine(dt);

            Console.WriteLine(dt.Date);
            Console.WriteLine(dt.TimeOfDay);
            Console.WriteLine(dt.Ticks);

            Thread.Sleep(3000);

            Console.WriteLine(dt);

            AdunareSecunde(ref dt, 3);
            //dt = dt.AddSeconds(3);

            Console.WriteLine(dt);

            DT d = new DT(12, 57, 34);
            Console.WriteLine(d);

            IncrementSecunda(d);

            Console.WriteLine(d);
        }

        private static void IncrementSecunda(DT d)
        {
            d.Secunda = d.Secunda + 1;
        }

        private static void AdunareSecunde(ref DateTime dt, int v)
        {
            dt = dt.AddSeconds(v);
        }
    }
}
