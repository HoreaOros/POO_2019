using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bars
{
    class Program
    {
        static void Main(string[] args)
        {
            HorzBar h1 = new HorzBar(3);

            VertBar v1 = new VertBar(3);

            Frame f1 = new Frame(3, 2);

            Ladder ladd = new Ladder(10, 5, 1);

            Console.WriteLine("h1 width = {0}", h1.Lungime);

            Console.WriteLine("v1 height = {0}", v1.Inaltime);


            // TODO;
            Console.WriteLine("f1 width = {0}", f1.Lungime);

            Console.WriteLine("f1 height = {0}", f1.Inaltime);


            // TODO Ladder
        }
    }
}
