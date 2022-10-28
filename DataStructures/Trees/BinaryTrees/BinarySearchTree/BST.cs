using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataStructures.Trees.BinaryTrees;

namespace Trees.BinaryTrees.BinarySearchTree
{
    public class BST<T>
    where T : IComparable
    {
        public Node<T> Root { get; set; }
        public BST()
        {
            Root = null;
        }
        public BST(Node<T> node)
        {
            Root = node;
        }
        public BST(IEnumerable<T> collection):this()
        {
            foreach (var item in collection)
                Add(item);
        }

        public void Add(T value)
        {
             var newNode = new Node<T>(value);
             if(Root == null)
             {
                    Root = newNode;
                    return;
             }
            var current = Root;
            Node<T> parent;
            while (true)
            {
                parent = current;
                // Left Add
                if(value.CompareTo(current.Value)< 0)
                {
                    current = current.Left;
                    if(current == null)
                    {
                        parent.Left = newNode;
                        return;
                    }
                }

                // Right
                 else
                {
                    current = current.Right;
                    if(current == null)
                    {
                        parent.Right = newNode;
                        return;
                    }
                }

            }
        }
        
        public T FindMin(Node<T> root)
        {
            T minValue = root.Value;
            while (root.Left !=null)
            {
                minValue  = root.Left.Value;
                root = root.Left;
            }
            return minValue;
        }

        public T FindMin()
        {
            if(Root == null)
                throw new ArgumentNullException("Empty Tree Node");
            Node<T> current = Root;
            T minValue = current.Value;
            while (current.Left !=null)
            {
                minValue  = current.Left.Value;
                current = current.Left;
            }
            return minValue;
        }

        public T FindMax()
        {
            if(Root == null)
                throw new ArgumentNullException("Empty Tree Node");
            var current = Root;
            while(!(current.Right == null))
                current = current.Right;
            return current.Value;

        }

        public Node<T> Find(T key)
        {
            if(Root == null)
                throw new ArgumentNullException("Empty Tree Node");
             var current = Root;
             while (current.Value.CompareTo(key) !=0)
             {
                if(key.CompareTo(current.Value) < 0)
                    current = current.Left;
                else
                    current = current.Right;
                if(current == null)
                    throw new Exception("Could not found!");
             }

             return current;
        }

        public Node<T> Remove(Node<T> root, T key)
        {
            if(root == null)
                throw new Exception("Empty tree!");

            if(key.CompareTo(root.Value)< 0)
                root.Left = Remove(root.Left, key);

            else if(key.CompareTo(root.Value) > 0)
                root.Right = Remove(root.Right, key);

            else
            {
                // Deletion procedure
                // Single child or  child
                if(root.Left == null)
                    return root.Right;
                else if(root.Right == null)
                    return root.Left;
                // double child
                root.Value = FindMin(root.Right);

                root.Right = Remove(root.Right, root.Value);
            }
            return root;
       
        }
    }
}