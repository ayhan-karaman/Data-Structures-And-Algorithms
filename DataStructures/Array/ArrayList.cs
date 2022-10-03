using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructures.Array
{
    public class ArrayList : Array, IEnumerable
    {
        private int position;
        public int Count => position;
        public ArrayList(int defaultSize = 2) : base(defaultSize)
        {
            position = 0;

        }
        public ArrayList(IEnumerable collection)
        {
          foreach (var item in collection)
          {
            Add(item);
          }   
        }
        public void Add(Object value)
        {
            if(position == Length)
            {
                DoubleArray();
            }
            if(position < Length)
            {
                InnerArray[position] = value;
                position++;
                return;
            }
            throw new Exception();
        }

        private void DoubleArray()
        {
            try
            {
                var temp = new Object[InnerArray.Length *2];
                System.Array.Copy(InnerArray, temp, InnerArray.Length);
                InnerArray = temp;
            }
            catch (System.Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }
        public Object Remove()
        {
            if(position >= 0)
            {
                var temp = InnerArray[position -1];
                position--;
                if(position == InnerArray.Length / 4)
                    HalfArray();
                
                return temp;
            }
            throw new Exception();
        }

        private void HalfArray()
        {
            try
            {
                var temp = new Object[InnerArray.Length / 2];
                System.Array.Copy(InnerArray, temp, InnerArray.Length / 2);
                InnerArray = temp;
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
                
            }
        }
       
        new public IEnumerator GetEnumerator()
        {
            return InnerArray.Take(position).GetEnumerator();
        }
    }
}