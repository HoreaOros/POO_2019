using System;

namespace MyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyArray ma = new MyArray(100);

            for (int i = 0; i < 10; i++)
            {
                ma.Add(i * i);
            }

            ma[3] += 5;

            Console.WriteLine(ma);

            // elimina toate aparatiile argumenului din vector
            //ma.Remove(14);
        }
    }
}
