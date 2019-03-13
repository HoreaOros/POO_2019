using System;

namespace Number
{
    // Modeleaza un numar natural
    internal class Numar
    {
        private readonly ulong v;

        public Numar(ulong v)
        {
            this.v = v;
        }

        public ulong Value
        {
            get
            {
                return v;
            }
        }

        /// <summary>
        /// Determina numarul de divizori (ineficient)
        /// </summary>
        public int NumarDivizori 
        {
            get
            {
                int nd = 2;
                if (v == 1)
                    return 1;
                for (ulong d = 2; d <= v / 2; d++)
                {
                    if (v % d == 0)
                    {
                        nd++;
                    }
                }
                return nd;
            }
        
        }

        /// <summary>
        /// Determina numarul de divizori (eficient)
        /// </summary>
        public int NumarDivizori2
        {
            get
            {
                int nd = 1;
                ulong aux = v;
                ulong p = 2;
                while (aux > 1)
                {
                    int q = 0;
                    while (aux % p == 0)
                    {
                        q++;
                        aux /= p;
                    }
                    nd *= (q + 1);
                    Numar n2 = new Numar(aux);
                    if (n2.EstePrim())
                    {
                        nd *= 2;
                        aux = 1;
                    }
                    p++;
                }
                return nd;
            }

        }

        public ulong SumaDivizori
        {
            get
            {
                ulong sd = 1;
                ulong aux = v;
                ulong p = 2;
                while (aux > 1)
                {
                    ulong q = 1;
                    while (aux % p == 0)
                    {
                        q = q * p + 1;
                        aux /= p;
                    }
                    sd *= q;
                    Numar n2 = new Numar(aux);
                    if (n2.EstePrim())
                    {
                        sd *= (1 + aux);
                        aux = 1;
                    }
                    p++;
                }
                return sd;
            }

        }

        /// <summary>
        /// Calculeaza suma cifrelor numarului
        /// </summary>
        /// <returns></returns>
        public ulong SumaCifre()
        {
            ulong suma = 0;
            ulong aux = v;
            while (aux > 0)
            {
                suma += aux % 10;
                aux /= 10;
            }
            return suma;
        }

        /// <summary>
        /// Test de primalitate determinist
        /// </summary>
        /// <returns>true daca numarul este prim, false daca este compus</returns>
        public bool EstePrim()
        {
            if (v < 2)
            {
                return false;
            }
            if (v == 2)
            {
                return true;
            }
            if (v % 2 == 0)
            {
                return false;
            }
            for (ulong d = 3; d * d <= v; d += 2)
            {
                if (v % d == 0)
                {
                    return false;
                }
            }

            return true;

        }
    }
}