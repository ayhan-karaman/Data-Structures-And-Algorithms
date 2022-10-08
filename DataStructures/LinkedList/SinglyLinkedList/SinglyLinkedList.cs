using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.SinglyLinkedList
{    public class SinglyLinkedList<T>
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
             Count++;
             return;
        }
    }
}