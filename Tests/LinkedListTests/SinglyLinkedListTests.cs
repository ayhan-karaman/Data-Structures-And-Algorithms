using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataStructures.LinkedList.SinglyLinkedList;
using Xunit;

namespace Tests.LinkedListTests
{
    public class SinglyLinkedListTests
    {
        private  SinglyLinkedList<int> _linkedList;
        public SinglyLinkedListTests()
        {
            _linkedList = new SinglyLinkedList<int>(new int[] {6, 8});
        }
        [Fact]
        public void Count_Test()
        {
            // Act
            int count = _linkedList.Count;
            // Assert
            Assert.True(count == 2);
        }

        [Theory]
        [InlineData(6)]
        [InlineData(10)]
        [InlineData(15)]
        [InlineData(1)]
        [InlineData(9)]
        public void AddFirst_Tests(int value)
        {
            // Act 
            _linkedList.AddFirst(value);
            // Assert
            Assert.Equal(value, _linkedList.Head.Value);
            Assert.Collection(_linkedList,
            item => Assert.Equal(item, value),
            item => Assert.Equal(item, 8),
            item => Assert.Equal(item, 6)
            );
        }

        [Theory]
        [InlineData(6)]
        [InlineData(10)]
        [InlineData(15)]
        [InlineData(1)]
        [InlineData(9)]
        public void AddLast_Tests(int value)
        {
            // Act 
            _linkedList.AddLast(value);

            // Assert
            Assert.Collection(_linkedList,
            item => Assert.Equal(item, 8),
            item => Assert.Equal(item, 6),
            item => Assert.Equal(item, value)
            );
        }

        [Theory]
        [InlineData(6)]
        [InlineData(10)]
        [InlineData(15)]
        [InlineData(1)]
        [InlineData(9)]
        public void AddBefore_Tests(int value)
        {
             // act
             _linkedList.AddBefore(_linkedList.Head.Next, value);

             // assert
             Assert.Collection(_linkedList,
            item => Assert.Equal(item, 8),
            item => Assert.Equal(item, value),
            item => Assert.Equal(item, 6)
            );
        }

        

        [Fact]
        public void AddBefore_ArgumentException()
        {
            // act
            var node = new SinglyLinkedListNode<int>(28);

            // assert
            Assert.Throws<ArgumentException>(()=> _linkedList.AddBefore(node, 55));
        }

        [Fact]
        public void AddBefore_ArgumentNullException()
        {
            // assert
            Assert.Throws<ArgumentNullException>(()=> _linkedList.AddBefore(null!, 55));
        }

        [Theory]
        [InlineData(6)]
        [InlineData(10)]
        [InlineData(15)]
        [InlineData(1)]
        [InlineData(9)]
        public void AddAfter_Tests(int value)
        {
             // act
             _linkedList.AddAfter(_linkedList.Head, value);

             // assert
             Assert.Collection(_linkedList,
            item => Assert.Equal(item, 8),
            item => Assert.Equal(item, value),
            item => Assert.Equal(item, 6)
            );
        }

        [Fact]
        public void AddAfter_ArgumentException()
        {
            // act
            var node = new SinglyLinkedListNode<int>(28);

            // assert
            Assert.Throws<ArgumentException>(()=> _linkedList.AddAfter(node, 55));
        }

        [Fact]
        public void AddAfter_ArgumentNullException()
        {
            // assert
            Assert.Throws<ArgumentNullException>(()=> _linkedList.AddAfter(null!, 55));
        }

        [Fact]
        public void GetEnumerator_Tests()
        {
            // Assert
            Assert.Collection(_linkedList, 
            item => Assert.Equal(item, 8),
            item => Assert.Equal(item, 6) 
            );
        }
    }
}