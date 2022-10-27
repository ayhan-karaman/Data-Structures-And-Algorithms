using System.Collections;

namespace DataStructures.Trees.BinaryTrees;
public class BinaryTree<T> :IEnumerable
{
    public Node<T> Root { get; set; }
    public int Count { get; set; }
    private bool isRootNull => Root == null;
    public BinaryTree()
    {
        Count = 0;
    }
    public BinaryTree(IEnumerable<T> collection)
    {
        foreach (var item in collection)
            Insert(item);
    }
    public T Insert(T value)
    {
        var newNode = new Node<T>(value);
        // Root ? 
        if(isRootNull)
        {
            Root = newNode;
            Count++;
            return value;
        }
          var list = new List<Node<T>>();
          var q = new Queue<Node<T>>();
           q.Enqueue(Root);
            while (q.Count > 0)
            {
                var temp = q.Dequeue();
                list.Add(temp);
                if(temp.Left != null) 
                    q.Enqueue(temp.Left);
                else
                {
                    temp.Left = newNode;
                    Count++;
                    return value;
                }
                    
                if(temp.Right != null) 
                    q.Enqueue(temp.Right);
                else 
                {
                    temp.Right = newNode;
                    Count++;
                    return value;
                }
                    
            }
            throw new  Exception("The insertion operation failed.");
           
    }

    public static List<Node<T>> LevelOrderTraverse(Node<T> root)
    {
        var list = new List<Node<T>>();
        if (root != null)
        {
            var q = new Queue<Node<T>>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                var temp = q.Dequeue();
                list.Add(temp);
                if(temp.Left != null) q.Enqueue(temp.Left);
                if(temp.Right != null) q.Enqueue(temp.Right);
            }
        }
        return list;
    }

    public IEnumerator GetEnumerator()
    {
        return LevelOrderTraverse(this.Root).GetEnumerator();
    }

    public T Delete(T value)
    {
        throw new NotImplementedException();
    }
    public T Delete()
    {
        // last element deleted
        throw new NotImplementedException();
    }
}
