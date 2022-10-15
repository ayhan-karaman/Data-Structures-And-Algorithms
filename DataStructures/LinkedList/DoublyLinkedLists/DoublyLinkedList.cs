using System.Collections;

namespace DataStructures.LinkedList.DoublyLinkedLists
{
    public class DoublyLinkedList<T>: IEnumerable<T>
    {
        public int Count { get; private set; }
        public DoublyLinkedListNode<T> Head { get; private set; }
        public DoublyLinkedListNode<T> Tail { get; private set; }
        private bool isHeadNull => Head == null;
        public DoublyLinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public DoublyLinkedList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                AddLast(item);
            }
        }

        public void AddFirst(T value)
        {
            var newNode = new DoublyLinkedListNode<T>(value);
            if(isHeadNull)
            {
                Head = newNode;
                Tail = newNode;
                Count++;
                return;
            }
            newNode.Next = Head;
            Head.Prev = newNode;
            Head = newNode;
            Count++;
            return;
        }

        public void AddBefore(DoublyLinkedListNode<T> node,  T value)
        {
            if(node == null || value is null)
            throw new ArgumentNullException();
            if(isHeadNull || node.Equals(Head))
            {
                AddFirst(value);
                return;
            }
            var newNode = new DoublyLinkedListNode<T>(value);
            var current = Head;
            var prev = current;
            while (current != null)
            {
                if(current.Equals(node))
                {
                    newNode.Next = prev.Next;
                    newNode.Prev = prev;
                    prev.Next = newNode;
                    newNode.Next.Prev = newNode;
                    Count++;
                    return;
                }
                prev = current;
                current = current.Next;
            }
             throw new ArgumentException("There is no such a node in the linked list");

        }

        public void AddAfter(DoublyLinkedListNode<T> node, T value)
        {
            if(node == null)
            throw new ArgumentNullException();
            if(isHeadNull)
            {
                AddFirst(value);
                return;
            }
            var newNode = new DoublyLinkedListNode<T>(value);
            var current = Head;
            while (current != null)
            {
                if(current.Equals(node))
                {
                    if(current.Next != null)
                    {
                        newNode.Next = current.Next;
                        current.Next = newNode;
                        newNode.Prev = current;
                        newNode.Next.Prev = newNode;
                        Count++;
                        return;
                    }
                    else
                    {
                        AddLast(value);
                        return;
                    }
                }
                current = current.Next;
            }
            throw new ArgumentException("There is no such a node in the linked list");
        }

        public void AddLast(T value)
        {
            var newNode = new DoublyLinkedListNode<T>(value);
            if(isHeadNull)
            {
                AddFirst(value);
                return;
            }
            Tail.Next = newNode;
            newNode.Prev = Tail;
            Tail = newNode;
            Count++;
            return;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return new DoublyLinkedListEnumerator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public List<T> ToList() => new List<T>(this);
    }
}