using System;
namespace Inheritance
{
    internal class Dreptunghi: FormaGeometrica
    {
        public Dreptunghi()
        {
            Console.WriteLine("Am creat un dreptunghi");
        }
        public override void Draw()
        {
            Console.WriteLine("Am desenat un dreptunghi");
        }
        public int Perimetru()
        {
            return 0;
        }
    }
}