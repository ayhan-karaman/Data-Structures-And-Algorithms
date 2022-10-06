using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructures.Array.Generic
{
    public class CustomGenericArrayEnumerator<T> : IEnumerator<T>
    {
        private T[] _array;
        private int index = -1;
        private int _position;
        public CustomGenericArrayEnumerator(T[] array, int position)
        {
            _array = array;
            _position = position;

        }
        public T Current =>  _array[index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            _array = null;
        }

        public bool MoveNext()
        {
            if(index < _position)
            {
                index++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}