using System.Collections;
using DataStructures.Stack.Contracts;

namespace DataStructures.Stack;
public class Stack<T> : IStack<T>
{
    private readonly Stack<T> _stack;
    public int Count => _stack.Count;

    public IEnumerator<T> GetEnumerator()
    {
        return _stack.GetEnumerator();
    }

    public T Peek()
    {
        return _stack.Peek();
    }

    public T Pop()
    {
        return _stack.Pop();
    }

    public void Push(T item)
    {
        _stack.Push(item);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
