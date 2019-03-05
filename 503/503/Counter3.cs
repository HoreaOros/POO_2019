using System;

namespace _503
{
    internal class Counter3
    {
        private Counter c1, c2, c3;
        public Counter3()
        {
            c1 = new Counter();
            c2 = new Counter();
            c3 = new Counter();
        }

        public string Value
        {
            get
            {
                return c1.Value.ToString() + c2.Value.ToString() + c3.Value.ToString();
            }
        
        }

        public void Count()
        {
            c3.Count();
            if(c3.Value == 0)
            {
                c2.Count();
                if(c2.Value == 0)
                {
                    c1.Count();
                }
            }
        }
    }
}