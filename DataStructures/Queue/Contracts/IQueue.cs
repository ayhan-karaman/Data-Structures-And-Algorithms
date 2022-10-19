using System;
namespace DataStructures.Queue.Contracts
{
    public interface IQueue<T> : IEnumerable<T>
    {
        int Count { get;  }
        void EnQueue(T item);
        T DeQueue();
        T Peek();
    }
}

