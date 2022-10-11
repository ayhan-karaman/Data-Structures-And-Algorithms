using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.SinglyLinkedList
{
    public class SinglyLinkedList<T> :IEnumerable<T>
    {
        public SinglyLinkedListNode<T> Head { get; set; }
        public int Count { get; set; }
        private bool isHeadNull => Head == null;
        public SinglyLinkedList()
        {
            Head = null;
            Count = 0;
        }

        public SinglyLinkedList(IEnumerable<T> collection):this()
        {
            foreach (var item in collection)
            {
                AddFirst(item);
            }
        }

        public void AddFirst(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);
            if(isHeadNull)
            {
                Head = newNode;
                Count++;
                return;
            }
             newNode.Next  = Head;
             Head = newNode;
             Count++;
             return;
        }
        public void AddLast(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);
            if(isHeadNull)
            {
                Head = newNode;
                Count++;
                return;
            }
            var current = Head;
            var prev = current;
            while (current != null)
            {
                prev = current;
                current = current.Next;
            }
            prev.Next = newNode;
            Count++;
            return;
        }

        public void AddBefore(SinglyLinkedListNode<T> node, T value)
        {
            if(node == null)
                throw new ArgumentNullException(nameof(node));
            if(isHeadNull || node.Equals(Head))
            {
                AddFirst(value); 
                return;
            }
            var newNode = new SinglyLinkedListNode<T>(value);
            var current = Head;
            var prev = current;
            while (current != null)
            {
                if(current.Equals(node))
                {
                    newNode.Next = prev.Next;
                    prev.Next = newNode;
                    Count++;
                    return;
                }
                prev = current;
                current = current.Next;
            }
            throw new ArgumentException("There is no such a node in the linked list");  
        }

        public void AddAfter(SinglyLinkedListNode<T> node, T value)
        {
            if (node is null)
                throw new ArgumentNullException(nameof(node));
            if(isHeadNull)
            {
                AddFirst(value);
                return;
            }
            var newNode = new SinglyLinkedListNode<T>(value);
            var current =  Head;
            while (current != null)
            {
                if(current.Equals(node))
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    Count++;
                    return;
                }
                current = current.Next;
            }

            throw new ArgumentException("There is no such a node in the linked list");  
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new SinglyLinkedListEnumerator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public List<T> ToList() => new List<T>(this);
    }
}