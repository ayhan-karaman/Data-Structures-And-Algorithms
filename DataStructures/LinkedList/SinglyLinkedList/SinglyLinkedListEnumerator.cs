using System.Collections;

namespace DataStructures.LinkedList.SinglyLinkedList
{
    public class SinglyLinkedListEnumerator<T> : IEnumerator<T>
    {
        private SinglyLinkedListNode<T> Head { get; set; }
        private SinglyLinkedListNode<T> NodeCurrent { get; set; }
        public SinglyLinkedListEnumerator(SinglyLinkedListNode<T> head)
        {
            Head = head;
            NodeCurrent = null;
        }
        public T Current => NodeCurrent.Value;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            Head = null;
        }

        public bool MoveNext()
        {
            if(Head is null)
             return false;
            if(NodeCurrent == null)
            {
                NodeCurrent = Head;
                return true;
            }
            if(NodeCurrent.Next != null)
            {
                NodeCurrent = NodeCurrent.Next;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            Head = null;
            NodeCurrent = null;
        }


    }
}