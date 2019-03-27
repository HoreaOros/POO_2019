using System;
using System.Collections.Generic;
using System.Text;

namespace Huge
{
    class Huge
    {
        private byte[] data;
        private int digits;
        public Huge()
        {

        }
        public Huge(int v)
        {
            int digits;

            digits = CountDigits(v);

            data = new byte[digits];
            this.digits = digits;
            for (int i = 0; v > 0; i++)
            {
                data[i] = (byte)(v % 10);
                v = v / 10;
            }
        }

        public int Digits
        {
            get
            {
                return digits;
            }
        }
        public Huge(string v)
        {
            digits = v.Length;
            data = new byte[digits];

            for (int i = digits - 1; i >= 0; i--)
            {
                data[digits - 1 - i] = (byte)(v[i] - '0');
            }
        }

        private int CountDigits(int v)
        {
            int contor = 0;
            while (v > 0)
            {
                v = v / 10;
                contor++;
            }
            return contor;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = digits - 1; i >= 0; i--)
            {
                sb.Append(data[i]);
            }

            return sb.ToString();
        }
        public static Huge operator+(Huge left, Huge right)
        {
            Huge result = new Huge();
            int contor = 0;
            byte[] suma = new byte[Math.Max(left.digits, right.Digits) + 1];
            int carry = 0;
            int i;
            for (i = 0; i < Math.Min(left.Digits, right.digits); i++)
            {
                suma[i] = (byte)((carry + left.data[i] + right.data[i]) % 10);
                contor++;
                carry = (carry + left.data[i] + right.data[i]) / 10;
            }
            int j;
            for (j = i; j < left.Digits; j++)
            {
                suma[j] = (byte)((carry + left.data[j]) % 10);
                contor++;
                carry = (carry + left.data[i]) / 10;
            }
            for (j = i; j < right.Digits; j++)
            {
                suma[j] = (byte)((carry + right.data[j]) % 10);
                contor++;
                carry = (carry + right.data[i]) / 10;
            }
            if (carry > 0)
            {
                suma[j] = (byte)carry;
                contor++;
            }
            result.data = suma;
            result.digits = contor;
            return result;
        }
    }
}
