using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataStructures.LinkedList.SinglyLinkedList;
using DataStructures.Stack.Contracts;

namespace DataStructures.Stack
{
    public class LinkedListStack<T> : IStack<T>
    {
        private readonly SinglyLinkedList<T> _linkedList;
        public int Count => _linkedList.Count;
        public LinkedListStack()
        {
            _linkedList = new SinglyLinkedList<T>();
        }
        public LinkedListStack(IEnumerable<T> collection):this()
        {
            foreach (var item in collection)
                Push(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return  _linkedList.GetEnumerator();
        }

        public T Peek()
        {
            return Count == 0 ?  default(T) : _linkedList.Head.Value;
        }

        public T Pop()
        {
            if(Count == 0)
                throw new Exception("Empty Stack!");
            var result = _linkedList.RemoveFirst();
            return result;
        }

        public void Push(T item)
        {
            _linkedList.AddFirst(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}