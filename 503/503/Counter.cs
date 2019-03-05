using System;

namespace _503
{
    internal class Counter
    {
        private int value;
       

        public Counter()
        {
            value = 0;
        }

        public Counter(int value)
        {
            this.value = value;
        }

        public int Value
        {
            get
            {
                return value;
            }
         }

        public void Count()
        {
            value++;
            if (value == 10)
                value = 0;
        }

        public void Reset()
        {
            value = 0;
        }
    }
}