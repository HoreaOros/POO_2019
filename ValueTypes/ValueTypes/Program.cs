using System;
using HelperTypes;
using System.IO;

namespace ValueTypes
{
    class Program
    {
        struct Point
        {
            int x, y;

            public void Print()
            {
                Console.WriteLine("({0}, {1})", x, y);
            }
            public Point(int a, int b)
            {
                x = a;
                y = b;
            }
        }
        struct Person
        {
            string nume;
            DataCalendaristica dataNasterii;
            public Person(string nm, DataCalendaristica dn)
            {
                nume = nm;
                dataNasterii = dn;
            }
            public void Print()
            {
                Console.WriteLine(nume);
                Console.Write("\t");
                dataNasterii.Print();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Point p = new Point(2, 3);

            p.Print();

            Person p1 = new Person("John Doe", new DataCalendaristica(12, Luna.Martie, 2019));

            p1.Print();

            // shortCircuit
            ShortCircuit();

            //Enum test;

            Console.WriteLine("Introduceti un numar (1-12)");
            int m = int.Parse(Console.ReadLine());

            Luna luna = (Luna)m;
            Console.WriteLine(luna);

            switch (luna)
            {
                case Luna.Ianuarie:
                    break;
                case Luna.Februarie:
                    break;
                case Luna.Martie:
                    break;
                case Luna.Aprilie:
                    break;
                case Luna.Mai:
                    break;
                case Luna.Iunie:
                    break;
                case Luna.Iulie:
                    break;
                case Luna.August:
                    break;
                case Luna.Septembrie:
                    break;
                case Luna.Octombrie:
                    break;
                case Luna.Noiembrie:
                    break;
                case Luna.Decembrie:
                    break;
                default:
                    break;
            }


            foreach (var item in Enum.GetNames(typeof(Luna)))
            {
                Console.WriteLine(item);
            }

        }

        

        private static void ShortCircuit()
        {
            int[] v = { 1, 2, 4, 7 };
            int suma = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i < v.Length && v[i] % 2 == 1)
                {
                    suma += v[i];
                }
            }

            Console.WriteLine(suma);

          
        }
    }
}
