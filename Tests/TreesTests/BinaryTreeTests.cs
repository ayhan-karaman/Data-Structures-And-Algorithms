using System;
using System.Collections.Generic;
using System.Linq;
using DataStructures.Trees.BinaryTrees;
using Xunit;

namespace Tests.TreesTests
{
    public class BinaryTreeTests
    {
        private readonly BinaryTree<int> _binaryTree;
        public BinaryTreeTests()
        {
             // Arrenge
            _binaryTree = new BinaryTree<int>();
        }
        [Fact]
        public void Insert_Create_Test()
        {
             // Act
             _binaryTree.Insert(1);
             // Assert
            Assert.Equal(1, _binaryTree.Root.Value);
        }

        [Fact]
        public void Insert_Check_Left_Node()
        {
            // Act
            _binaryTree.Insert(1);
            _binaryTree.Insert(2);
        
            // Assert
            Assert.Equal(1, _binaryTree.Root.Value);
            Assert.Equal(2, _binaryTree.Root.Left.Value);
        }

        [Fact]
        public void Insert_Check_Right_Node()
        {
            // Act
            _binaryTree.Insert(1);
            _binaryTree.Insert(2);
            _binaryTree.Insert(3);
            // Assert
            Assert.Equal(1, _binaryTree.Root.Value);
            Assert.Equal(2, _binaryTree.Root.Left.Value);
            Assert.Equal(3, _binaryTree.Root.Right.Value);
        }

        [Fact]
        public void Multiple_Insertion_Check()
        {
            // Act
            new int[] {1, 2, 3, 4, 5, 6, 7}.ToList()
            .ForEach(x => _binaryTree.Insert(x));
           //        1
           //     /     \
           //    2       3
           //   / \     /  \
           //  4   5   6    7 

        
            // Assert
            Assert.Equal(1, _binaryTree.Root.Value);
            Assert.Equal(2, _binaryTree.Root.Left.Value);
            Assert.Equal(3, _binaryTree.Root.Right.Value);
            Assert.Equal(4, _binaryTree.Root.Left.Left.Value);
            Assert.Equal(5, _binaryTree.Root.Left.Right.Value);
            Assert.Equal(6, _binaryTree.Root.Right.Left.Value);
            Assert.Equal(7, _binaryTree.Root.Right.Right.Value);

        }

        [Fact]
        public void Count_Check_Test()
        {
            // Act
            new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
            .Where(x => x % 2 == 0)
            .ToList()
            .ForEach(x => _binaryTree.Insert(x));
/*
                       2
                     /   \
                    4     6
                  /  \
                 8    10
*/

            // Assert
            Assert.Equal(2, _binaryTree.Root.Value);
            Assert.Equal(4, _binaryTree.Root.Left.Value);
            Assert.Equal(6, _binaryTree.Root.Right.Value);
            Assert.Equal(8, _binaryTree.Root.Left.Left.Value);
            Assert.Equal(10, _binaryTree.Root.Left.Right.Value);

            // Assert Null Condition
            Assert.Null(_binaryTree.Root.Right.Left);
            Assert.Null(_binaryTree.Root.Right.Right);

            Assert.True(_binaryTree.Count == 5);
        }

        [Fact]
        public void Level_Order_Traverse_Test()
        {
            // Act
            new int[] {1, 2, 3, 4, 5, 6, 7}
            .ToList()
            .ForEach(x => _binaryTree.Insert(x));
             var list = BinaryTree<int>.LevelOrderTraverse(_binaryTree.Root);
            // Assert
            Assert.Collection(list, 
            item => Assert.Equal(_binaryTree.Root.Value, item.Value),
            item => Assert.Equal(2, item.Value),
            item => Assert.Equal(3, item.Value),
            item => Assert.Equal(4, item.Value),
            item => Assert.Equal(5, item.Value),
            item => Assert.Equal(6, item.Value),
            item => Assert.Equal(7, item.Value)
            );

            Assert.Equal(7, _binaryTree.Count);
        }

        [Fact]
        public void IsLeaf_Test()
        {
            // Act
              new int[] {1, 2, 3, 4, 5, 6, 7}.ToList()
            .ForEach(x => _binaryTree.Insert(x));
            // Assert
            Assert.True(_binaryTree.Root.Left.Left.IsLeaf);
        }

        [Fact]
        public void IsNotLeaf_Test()
        {
            // Act
              new int[] {1, 2, 3, 4, 5, 6, 7}.ToList()
            .ForEach(x => _binaryTree.Insert(x));
            // Assert
            Assert.False(_binaryTree.Root.Right.IsLeaf);
        }
    }
}