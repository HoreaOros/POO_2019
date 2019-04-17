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


            MyArray zeroArray = new MyArray(0);
            Console.WriteLine(zeroArray);

            //TODO
            // elimina toate aparatiile argumenului din vector
            //ma.Remove(14);


            // cautare liniara. daca nu este gasita valoarea metoda
            // intoarce fals si index are valoarea -1;

            //int index;
            //bool found = ma.Find(81, out index);

            // suma elementelor din vector
            // int suma = ma.Sum();

            //int value = 9;
            //MyArray indexes = ma.FindAll(value);
            //Console.WriteLine(indexes);

            //// modifica vectorul
            //ma.BubbleSort();
            //Console.WriteLine(ma);


            //ma.InsertionSort();

            //ma.SelectionSort();

            //// muta toate elementele din vector o pozitie la stanga
            //// primul element ajunge pe ultima pozitie. 
            //ma.RotateLeft();
            //Console.WriteLine(ma);
        }
    }
}
