using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataStructures.LinkedList.DoublyLinkedLists;
using DataStructures.Queue.Contracts;

namespace DataStructures.Queue
{
    public class LinkedListQueue<T> : IQueue<T>
    {
        private readonly DoublyLinkedList<T> _list;
        public LinkedListQueue()
        {
            _list = new DoublyLinkedList<T>();
        }
        public LinkedListQueue(IEnumerable<T> collection):this()
        {
            foreach (var item in collection)
                EnQueue(item);
        }
        public int Count => _list.Count;

        public T DeQueue()
        {
            if (Count == 0)
                throw new EmptyQueueException();
            var result = _list.RemoveFirst();
            return result;
        }

        public void EnQueue(T item)
        {
            _list.AddLast(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        public T Peek()
        {
            return Count == 0 ?  throw new EmptyQueueException() : _list.Head.Value;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}