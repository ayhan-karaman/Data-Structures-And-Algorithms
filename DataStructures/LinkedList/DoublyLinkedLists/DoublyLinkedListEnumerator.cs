using System.Collections;

namespace DataStructures.LinkedList.DoublyLinkedLists
{
    public class DoublyLinkedListEnumerator<T> : IEnumerator<T>
    {
        private DoublyLinkedListNode<T> Head { get; set; }
        private DoublyLinkedListNode<T> NodeCurrent { get; set; }
        public T Current => NodeCurrent.Value;

        object IEnumerator.Current => Current;
        public DoublyLinkedListEnumerator(DoublyLinkedListNode<T> head)
        {
            Head = head;
            NodeCurrent = null;
        }

        public void Dispose()
        {
            Head = null;
        }

        public bool MoveNext()
        {
            if(Head is null)
            return false;
            if(NodeCurrent is null)
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