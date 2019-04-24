using System;

namespace Inheritance
{
    class Program
    {
        static void DrawShape(FormaGeometrica f)
        {
            f.Draw();
        }

        static void Main(string[] args)
        {
            // o clasa abstracta nu poate fi instantiata.
            //FormaGeometrica fg = new FormaGeometrica();

            //fg.Draw();

            Cerc c = new Cerc();

            Dreptunghi d = new Dreptunghi();

            DrawShape(c);
            DrawShape(d);
        }
    }
}
