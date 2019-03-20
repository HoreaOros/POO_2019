using System;

namespace ADT
{
    internal class Stack
    {
        private int[] v;
        private int top = 0;
        public Stack()
        {
            v = new int[16];
        }

        public int Count
        {
            get
            {
                return top;
            }
        }

        public int Capacity
        {
            get
            {
                return v.Length;
            }
                
        }

        public bool IsEmpty
        {
            get
            {
                return top == 0;
            }
        }

        public int Peek()
        {
            if (!IsEmpty)
            {
                return v[top - 1];
            }
            else
                throw new StackEmptyException();
        }

        public bool IsFull
        {
            get
            {
                return top == Capacity;
            }
        }

        internal bool TryPeek(out int value)
        {
            if (!IsEmpty)
            {
                value = v[top - 1];
                return true;
            }
            else
            {
                value = 0;
                return false;
            }
                
        }

        public void Push(int value)
        {
            if (IsFull)
            {
                resize(Capacity * 2);
            }

            v[top++] = value;
        }

        private void resize(int size)
        {
            int[] v2 = new int[size];
            for (int i = 0; i < v.Length; i++)
            {
                v2[i] = v[i];
            }
            v = v2;
        }

        public int Pop()
        {
            if (top > 0)
            {
                top--;
                if (top < Capacity / 4)
                {
                    resize(Capacity / 2);
                }
                return v[top];
            }
            else
                throw new StackEmptyException();
        }
    }
}