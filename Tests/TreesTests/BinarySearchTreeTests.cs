using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataStructures.Trees.BinaryTrees;
using Trees.BinaryTrees.BinarySearchTree;
using Xunit;

namespace Tests.TreesTests
{
    public class BinarySearchTreeTests
    {
        private BST<int> _bst;
        public BinarySearchTreeTests()
        {
            // Arrenge
            _bst = new BST<int>();
        }
        [Fact]
        public void Add_Root_Test()
        {
             // Act
             _bst.Add(23);

             // Assert
            Assert.True(23 == _bst.Root.Value);
        }

        [Fact]
        public void In_Order_Iteration_Traverse_Test()
        {
            // Act
            var bst = new BST<int>(new List<int> {23, 16, 44, 3, 22, 99, 37});
            var list = BinaryTree<int>.InOrderIterationTraverse(bst.Root);
            // Assert
            Assert.Collection(list, 
            item => Assert.Equal(3, item),
            item => Assert.Equal(16, item),
            item => Assert.Equal(22, item),
            item => Assert.Equal(23, item),
            item => Assert.Equal(37, item),
            item => Assert.Equal(44, item),
            item => Assert.Equal(99, item)
            );
            Assert.True(7 == list.Count);

        }
        [Fact]
        public void FindMin_Test()
        {
            // Act
            var bst = new BST<int>(new List<int> {23, 16, 44, 3, 22, 99, 37});
            var min = bst.FindMin();
            // Assert
            Assert.Equal(3, min);
        } 

        [Fact]
        public void FindMax_Test()
        {
            // Act
            var bst = new BST<int>(new List<int> {23, 16, 44, 3, 22, 99, 37});
            var max = bst.FindMax();
            // Assert
            Assert.Equal(99, max);
        } 
        [Fact]
        public void Find_Test()
        {
            // Act
            var bst = new BST<int>(new List<int> {23, 16, 44, 3, 22, 99, 37});
            var node = bst.Find(22);
            // Assert
            Assert.Equal(node, bst.Root.Left.Right);

        }

        [Fact]
        public void Remove_A_Leaf_Test()
        {
            // Act
            var bst = new BST<int>(new List<int> {60, 40, 70, 20, 45, 65, 85});

            var node = bst.Remove(bst.Root, 20);
    
            // Assert
            var list = BinaryTree<int>.InOrderIterationTraverse(bst.Root);
            Assert.Collection(list,
            item => Assert.Equal(40, item),
            item => Assert.Equal(45, item),
            item => Assert.Equal(60, item),
            item => Assert.Equal(65, item),
            item => Assert.Equal(70, item),
            item => Assert.Equal(85, item)
             );
        }
        [Fact]
        public void Remove_A_Node_With_One_Child_Test()
        {
            // Act
            var bst = new BST<int>(new List<int> {60, 40, 70, 20, 45, 65, 85});

            var node = bst.Remove(bst.Root, 20);
            node = bst.Remove(bst.Root, 40);
    
            // Assert
            var list = BinaryTree<int>.InOrderIterationTraverse(bst.Root);
            Assert.Collection(list,
            item => Assert.Equal(45, item),
            item => Assert.Equal(60, item),
            item => Assert.Equal(65, item),
            item => Assert.Equal(70, item),
            item => Assert.Equal(85, item)
             );
        }

        [Fact]
        public void Remove_A_Node_With_Two_Child_Test()
        {
            // Arrenge
            var bst = new BST<int>(new List<int> {60, 40, 70, 20, 45, 65, 85});
            // Act
            var node = bst.Remove(bst.Root, 20);
            node = bst.Remove(bst.Root, 40);
            node = bst.Remove(bst.Root, 60);
            // Assert
            var list = BinaryTree<int>.InOrderIterationTraverse(bst.Root);
            Assert.Collection(list,
            item => Assert.Equal(45, item),
            item => Assert.Equal(65, item),
            item => Assert.Equal(70, item),
            item => Assert.Equal(85, item)
             );
        }
    }
}