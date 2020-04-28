using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace TestIComparable
{
    class SomeFigure: IComparable<int>
    {
        public int A { get; set; }
        public int B { get; set; }
        public int Area { get; set; }

        public int CompareTo([AllowNull] int other)
        {
            return Area.CompareTo(other);
        }
    }
}
