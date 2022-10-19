using System;
using System.Collections;
using DataStructures.Queue.Contracts;

namespace DataStructures.Queue
{
    public class ArrayQueue<T> : IQueue<T>
    {
        private readonly List<T> _innerArray;
        public ArrayQueue()
        {
            _innerArray = new List<T>();
        }
        public ArrayQueue(IEnumerable<T> collection):this()
        {
            foreach (var item in collection)
                EnQueue(item);
        }

        public int Count => _innerArray.Count;

        public T DeQueue()
        {
            if (Count == 0)
                throw new EmptyQueueException();
            // FIFO
            var temp = _innerArray[0];
            _innerArray.RemoveAt(0);
            return temp;
        }

        public void EnQueue(T item)
        {
            _innerArray.Add(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _innerArray.GetEnumerator();
        }

        public T Peek()
        {
           return Count == 0 ? default(T) : _innerArray[0];

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

