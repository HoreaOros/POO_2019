using System;
using System.IO;
namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s = Singleton.getInstance();



            
            Singleton t = Singleton.getInstance();
        }
    }
}
