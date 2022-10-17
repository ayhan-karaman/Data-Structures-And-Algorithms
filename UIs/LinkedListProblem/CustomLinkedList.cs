using System.Collections;
using System.Collections.Generic;

public class CustomLinkedList<T> : IEnumerable
{
    private  LinkedList<T> _list;
    public CustomLinkedList(T[] input)
    {
        _list = new LinkedList<T>();
        var hasHet = new HashSet<T>(input);
        var stack = new Stack<T>(hasHet);
        var n = stack.Count;
        for (var i = 0; i < n; i++)
        {
            _list.AddLast(stack.Pop());
        }
    }

    public IEnumerator GetEnumerator()
    {
        return _list.GetEnumerator();
    }
}