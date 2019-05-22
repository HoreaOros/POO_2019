using System.Collections.Generic;

namespace _2105
{
    internal class DescTimeComparer : IComparer<Time>
    {
        public int Compare(Time x, Time y)
        {
            return -x.CompareTo(y);
        }
    }
}