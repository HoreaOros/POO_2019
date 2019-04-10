using System;
using System.Collections.Generic;
using System.Text;

namespace ContBancar
{
    class ContBancar
    {
        //private readonly string titular;
        private readonly Guid no;
        private decimal sold;

        public ContBancar(): this(0)
        {
            
        }
        public ContBancar(decimal sold)
        {
            this.sold = sold;
            this.no = Guid.NewGuid();
            Console.WriteLine("[Am creat un cont bancar cu soldul {0}]", sold);
        }

        public void Retrage(decimal v)
        {
            Console.Write("Incerc sa retrag suma: {0}...", v);
            if (v < 0m)
                throw new InvalidAmountException(v);
            else if (v <= sold)
            {
                Console.WriteLine("Success!");
                sold -= v;
            }
                
            else
                throw new NotEnoughFundsException(v);
        }

        public void Depune(decimal v)
        {
            Console.Write("Incerc sa depun suma: {0}...", v);
            if (v < 0m)
                throw new InvalidAmountException(v);
            else
            {
                Console.WriteLine("Success!");
                sold += v;
            }
                
        }

        public override string ToString()
        {
            return "Cont bancar: " + no + Environment.NewLine + "Sold: " + sold;
        }
    }
}
