using System;
using System.Collections.Generic;

namespace _2105
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Time[] times = new Time[10];

            for (int i = 0; i < times.Length; i++)
            {
                times[i] = new Time();
            }

            Console.WriteLine("Before...");
            foreach (var item in times)
            {
                Console.WriteLine(item);
            }

            Array.Sort<Time>(times);


            Console.WriteLine("After...");
            foreach (var item in times)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Descending...");
            IComparer<Time> descTimeComparer = new DescTimeComparer();
            Array.Sort<Time>(times, descTimeComparer);
            foreach (var item in times)
            {
                Console.WriteLine(item);
            }

        }
    }
}
