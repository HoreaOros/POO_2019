using System;
namespace Inheritance
{
    internal abstract class FormaGeometrica
    {
        private Culoare color = Culoare.Verde;
        private int thickness = 1;
        public FormaGeometrica()
        {
            Console.WriteLine("Am creat o forma geometrica");
        }
        public abstract void Draw();
        

    }
}