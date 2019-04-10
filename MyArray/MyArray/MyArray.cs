using System;
using System.Collections.Generic;
using System.Text;

namespace MyArray
{
    class MyArray
    {
        private int[] arr;
        private int size; // numarul de elemente din vector

        public MyArray(int capacity)
        {
            arr = new int[capacity];
            size = 0;
        }
        public int Capacity
        {
            get
            {
                return arr.Length;
            }
        }

        public int this[int i]
        {
            get
            {
                return arr[i];
            }
            set
            {
                arr[i] = value;
            }
        }

        public void Add(int value)
        {
            if (size < Capacity)
            {
                arr[size] = value;
                size++;
            }
            else
                // TODO
                // situatie exceptionala. nu mai este spatiu in vector
                // trebuie alocat un vector mai mare in care sa punem elementul
                ;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("[");
            for (int i = 0; i < size; i++)
            {
                sb.Append(arr[i]);
                sb.Append(", ");
            }
            sb.Remove(sb.Length - 2, 2);
            sb.Append("]");
            return sb.ToString();
        }
    }
}
