using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructures.Stack.Contracts
{
    public interface IStack<T> : IEnumerable<T>
    {
        int Count { get; }
        T Peek();
        T Pop();
        void Push(T item);
    }
}