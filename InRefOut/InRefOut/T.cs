using System;
using System.Collections.Generic;
using System.Text;

namespace InRefOut
{
    class T
    {
        public int id;
        private static int count = 0;
        public T()
        {
            id = ++count;
        }
        // Metoda
        public static void SayHello()
        {
            Console.WriteLine("Hello");
        }


        // Metoda instanta
        public void SayGoodBye()
        {
            Console.WriteLine("GoodBye");
        }

        public override string ToString()
        {
            return "T : " + id;
        }
    }
}
