using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructures.Array
{
    public class Array
    {
        private Object[] InnerArray { get; set; }
        public int Length => InnerArray.Length;
        public Array(int defaultSize =16)
        {
            InnerArray = new Object[defaultSize];// fixed size
        }
    }
}