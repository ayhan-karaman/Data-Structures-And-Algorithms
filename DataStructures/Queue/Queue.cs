using System;
using System.Collections;
using DataStructures.Queue.Contracts;

namespace DataStructures.Queue
{
    public class Queue<T>:IQueue<T>
    {
        private readonly IQueue<T> _queue;

        public int Count => _queue.Count;

        public T DeQueue()
        {
           return _queue.DeQueue();
        }

        public void EnQueue(T item)
        {
            _queue.EnQueue(item);
        }


        public T Peek()
        {
            return _queue.Peek();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _queue.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

