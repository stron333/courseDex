using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace TestIComparable
{
    class SomeFigure: IComparable<int>
    {
        private int a;
        private int b;
        private int area;
        public int A
        {
            get
            {
                return a;
            }

            set
            {
                a = value;
                CountArea();
            }
        }
        public int B
        {
            get
            {
                return b;
            }

            set
            {
                b = value;
                CountArea();
            }
        }        

        public int Area
        {
            get
            {
                return area;
            }                        
        }

        public SomeFigure (int _a, int _b)
        {
            a = _a;
            b = _b;
            CountArea();
        }

        private void CountArea()
        {
            area = a * b;
        }
        public int CompareTo([AllowNull] int other)
        {
            return Area.CompareTo(other);
        }
    }
}
