using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.DoublyLinkedLists
{
    public class DoublyLinkedListNode<T>
    {
        public T Value { get; set; }
        public DoublyLinkedListNode<T> Prev { get; set; }
        public DoublyLinkedListNode<T> Next { get; set; }

        public DoublyLinkedListNode(T item)
        {
            Value = item;
        }

        public override string ToString() => $"{Value}";

    }
}