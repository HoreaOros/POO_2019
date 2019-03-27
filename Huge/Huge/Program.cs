using System;
using System.Numerics;
namespace Huge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Huge h1 = new Huge(123456789);
            Console.WriteLine(h1);
            Huge h2 = new Huge("999");
            Huge h3 = new Huge("11");

            Console.WriteLine(h2);
            Console.WriteLine(h3);
            Huge sum = h2 + h3;

            Console.WriteLine(sum);

            //Huge product = h2 * h3;

            //Console.WriteLine(product);

            Huge h4 = h2 + 1234567;

            //Huge h5 = h1.Power(10);

            //int mod = h4 % 135849752;

            //Console.WriteLine(h5);


           
        }
    }
}
