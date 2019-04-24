using System;
namespace Inheritance
{
    internal class Cerc: FormaGeometrica
    {
        public Cerc()
        {
            Console.WriteLine("Am creat un cerc");
        }
        public override void Draw()
        {
            Console.WriteLine("Am desenat un cerc");
        }
        public int Raza()
        {
            return 0;
        }
    }
}