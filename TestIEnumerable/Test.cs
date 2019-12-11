using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIEnumerable
{
    public class Father
    {
        //public string Name { get; set; }
    }

    class Son : Father
    {
        
    }

    class Mother
    {
        public Father BurnSon()
        {
            return new Father();
        }
    }
}
