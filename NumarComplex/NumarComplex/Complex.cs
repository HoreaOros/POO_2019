namespace NumarComplex
{
    internal class Complex
    {
        private double real, imag;

        public Complex(): this(0, 0)
        {
            
        }
        public Complex(double real, double imag)
        {
            this.real = real;
            this.imag = imag;
        }
        public static Complex  operator+(Complex left, Complex right)
        {
            Complex r = new Complex();

            r.real = left.real + right.real;
            r.imag = left.imag + right.imag;

            return r;
        }

        public override string ToString()
        {
            return "(" + real + ", " + imag + ")";
        }
    }
}