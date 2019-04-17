using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    class Matrix
    {
        private int[,] data;
        private int maxDigits = 1; // cum il actualizam???

        public int Rows
        {
            get
            {
                return data.GetLength(0);
            }
        }

        public int Columns
        {
            get
            {
                return data.GetLength(1);
            }
        }

        public Matrix(int linii, int coloane)
        {
            data = new int[linii, coloane];
        }
        public Matrix(int n): this(n, n)
        {

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            string formatString = "{0,";
            formatString += maxDigits;
            formatString += "}";

            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    sb.AppendFormat(formatString, data[i, j]);
                    sb.Append(" ");
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }

        public void RandomInit(int max)
        {
            maxDigits = (int)(Math.Floor(Math.Log10(max - 1)) + 1);
            Random rnd = new Random();
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    data[i, j] = rnd.Next(max);
                }
            }
        }
        public static Matrix operator*(Matrix a, Matrix b)
        {
            if (a.Columns != b.Rows)
            {
                throw new ImpossibleMatrixOperationException();
            }

            Matrix p = new Matrix(a.Rows, b.Columns);

            // inmultirea.

            for (int i = 0; i < p.Rows; i++)
            {
                for (int j = 0; j < p.Columns; j++)
                {
                    int suma = 0;
                    for (int k = 0; k < a.Columns; k++)
                    {
                        suma = suma + a[i, k] * b[k, j];
                    }
                    p[i, j] = suma;
                    p.maxDigits = Math.Max(p.maxDigits, (int)(Math.Floor(Math.Log10(p[i, j])) + 1)); 
                }
            }


            return p;
        }

        public int this[int i, int j]
        {
            get
            {
                return data[i, j];
            }
            set
            {
                data[i, j] = value;
            }
        }
        public static bool operator==(Matrix a, Matrix b)
        {
            throw new NotImplementedException();
        }
        public static bool operator !=(Matrix a, Matrix b)
        {
            throw new NotImplementedException();
        }
    }
}
