using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            World w1 = new World("ET1");
            w1.SayHello();

            World w2 = new World("ET2");
            w2.SayHello();

            World w3 = new World();
            w3.SayHello();
            
        }
    }
}
