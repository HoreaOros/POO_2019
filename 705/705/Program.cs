using System;

namespace _705
{
    class Program
    {
        static void doSomething(B b)
        {
           
            if (b is B)
            {
                b.f();
            }
            if(b is D)
            {
                ((D)b).f();
                ((D)b).g();
            }
            if (b is E)
            {
                ((E)b).f();
                ((E)b).h();
            }
        }
        static void Main(string[] args)
        {
            B b = new B();
            b.f();
           

            D d = new D();
            d.f();
            d.g();

            // upcasting
            B b1 = new D();
            b1.f();


            B b2 = new E();
            b2.f();

            doSomething(new B());
            doSomething(new D());
            doSomething(new E());
        }
    }
}
