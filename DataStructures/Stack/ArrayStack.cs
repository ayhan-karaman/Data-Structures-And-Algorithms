using System;
using System.Collections;
using DataStructures.Array.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataStructures.Stack.Contracts;

namespace DataStructures.Stack
{
    public class ArrayStack<T> : IStack<T>
    {
        private readonly Array<T> _array = new Array<T>();
        public int Count => _array.Count;

        public IEnumerator<T> GetEnumerator()
        {
           return  _array.GetEnumerator();
        }

        public T Peek()
        {
            if (Count == 0)
            {
                return default(T);
            }
            return _array.GetValue(_array.Count - 1);
        }

        public T Pop()
        {
            if(Count == 0)
                throw new Exception("Empty Stack");
            var result = _array.Remove();
            return result;
        }

        public void Push(T item)
        {
            _array.Add(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}