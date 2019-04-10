using System;

namespace ContBancar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ContBancar c1 = new ContBancar();
            ContBancar c2 = new ContBancar(100);

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            try
            {
                c1.Depune(500m);
                c1.Depune(700m);
                c1.Retrage(800m);
                c1.Retrage(900m);
            }
            catch (NotEnoughFundsException)
            {
                Console.WriteLine("Not enough money. Go get a job!");
            }
            catch (InvalidAmountException e)
            {
                Console.WriteLine("{0} not allowed", e.Amount);
            }
        }
    }
}
