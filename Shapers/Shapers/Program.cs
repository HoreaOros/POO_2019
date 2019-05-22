using System;
using System.Collections.Generic;
namespace Shapers
{
    class Program
    {
        static void Main(string[] args)
        {
            //testRnd();
            Circle c = new Circle();
            Console.WriteLine(c);

            Rectangle r1 = new Rectangle(2, 3);
            //Console.WriteLine(r1);

            Rectangle r2 = new Rectangle(2, 3, Color.Yellow, true);
            //Console.WriteLine(r2);

            List<Shape> lst = new List<Shape>();


            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                switch(rnd.Next(3))
                {
                    case 0:
                        lst.Add(new Circle(rnd.Next(10)));
                        break;
                    case 1:
                        lst.Add(new Rectangle(rnd.Next(10), rnd.Next(10)));
                        break;
                    case 2:
                        lst.Add(new Square(rnd.Next(10)));
                        break;
                }
            }

            foreach (Shape item in lst)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private static void testRnd()
        {
            Random rnd = new Random();

            int[] v = new int[10];


            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < v.Length; j++)
                {
                    v[j] = rnd.Next(3);
                }
                bool toateEgale = true;
                for (int j = 1; j < v.Length; j++)
                {
                    if (v[j] != v[j - 1])
                    {
                        toateEgale = false;
                        break;
                    }
                }
                if (toateEgale)
                {
                    Console.WriteLine("Toate egale  - {0}", i);
                    break;
                }
                    
            }
        }
    }
}
