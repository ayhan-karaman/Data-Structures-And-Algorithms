namespace DataStructures.Trees.BinaryTrees;

public class Node<T>
{
    public T Value { get; set; }
    public Node<T> Left { get; set; }
    public Node<T> Right { get; set; }
    public Node()
    {

    }
    public Node(T value)
    {
        Value = value;
    }

    public override string ToString()
    {
        return $"{Value}";
    }

    public bool IsLeaf => (Left == null && Right == null);
}
