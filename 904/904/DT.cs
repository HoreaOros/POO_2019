using System;
using System.Collections.Generic;
using System.Text;

namespace _904
{
    class DT
    {
        private int ora, minut, secunda;
        public DT(int ora, int minut, int secunda)
        {
            this.ora = ora;
            this.minut = minut;
            this.secunda = secunda;
        }
        public int Secunda
        {
            get
            {
                return secunda;
            }
            set
            {
                secunda = value;
            }
        }
        public override string ToString()
        {
            return ora.ToString() + "-" + minut.ToString() + "-" + secunda.ToString();

        }
    }
}
