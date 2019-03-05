using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _503
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter c = new Counter();

            c.Count();
            c.Count();
            c.Count();
            Console.WriteLine(c.Value);

            Counter c2 = new Counter();
            c2.Count();
            c2.Count();

            Console.WriteLine(c2.Value);

            Counter c3 = new Counter(4);
            c3.Count();
            Console.WriteLine(c3.Value);

            c3.Reset();

            for (int i = 0; i < 42; i++)
            {
                c3.Count();
            }
            Console.WriteLine(c3.Value);

            Counter3 ccc = new Counter3();
            for (int i = 0; i < 1000; i++)
            {
                ccc.Count();
            }

            Console.WriteLine(ccc.Value);


            /// TODO .......
            /// CounterN cnt = new CounterN(7);
        }
    }
}
