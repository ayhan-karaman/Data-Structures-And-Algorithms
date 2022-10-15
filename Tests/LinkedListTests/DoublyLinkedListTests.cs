using System;
using DataStructures.LinkedList.DoublyLinkedLists;
using Xunit;

namespace Tests.LinkedListTests
{
    public class DoublyLinkedListTests
    {
        private DoublyLinkedList<char> _linkedList;
        public DoublyLinkedListTests()
        {
            _linkedList = new DoublyLinkedList<char>(new char[] {'a', 'z'});
        }

        [Theory]
        [InlineData('e')]
        [InlineData('g')]
        [InlineData('B')]
        [InlineData('k')]
        [InlineData('H')]
        public void AddFirst_Tests(char value)
        {
            // act
            _linkedList.AddFirst(value);

            // assert
            Assert.Equal(value, _linkedList.Head.Value);
        }
        
        [Theory]
        [InlineData('i')]
        [InlineData('r')]
        [InlineData('d')]
        [InlineData('t')]
        [InlineData('l')]
        public void AddLast_Tests(char value)
        {
            // act
            _linkedList.AddLast(value);
            var tailValue = _linkedList.Tail.Value;

            // assert
            Assert.Equal(value, tailValue);
            Assert.Collection(_linkedList, 
            item => Assert.Equal(item, _linkedList.Head.Value), // O(1)
            item => Assert.Equal(item, _linkedList.Head.Next.Value), // O(n)
            item => Assert.Equal(item, _linkedList.Tail.Value)  // O(1)

            );
        }

        [Theory]
        [InlineData('i')]
        [InlineData('r')]
        [InlineData('d')]
        [InlineData('t')]
        [InlineData('l')]
        public void AddBefore_Tests(char value)
        {
            // act
            _linkedList.AddBefore(_linkedList.Head.Next, value);

            // assert
            Assert.Equal(value, _linkedList.Head.Next.Value);
            Assert.Collection(_linkedList, 
            item => Assert.Equal(item, _linkedList.Head.Value), // O(1)
            item => Assert.Equal(item, _linkedList.Head.Next.Value), // O(n)
            item => Assert.Equal(item, _linkedList.Tail.Value)  // O(1)

            );
        }

        [Fact]
        public void AddBefore_ArgumentException_Test()
        {
            // Arrenge
            var node = new DoublyLinkedListNode<char>('x');
            // Act & Assert
            Assert.Throws<ArgumentException>(()=> _linkedList.AddBefore(node, node.Value));
        }


        [Theory]
        [InlineData('i')]
        [InlineData('r')]
        [InlineData('d')]
        [InlineData('t')]
        [InlineData('l')]
        public void AddAfter_Tests(char value)
        {
            // act
            _linkedList.AddAfter(_linkedList.Head.Next, value);
            

            // assert
            Assert.Equal(value, _linkedList.Tail.Value);
            Assert.Collection(_linkedList, 
            item => Assert.Equal(item, _linkedList.Head.Value), // O(1)
            item => Assert.Equal(item, _linkedList.Head.Next.Value), // O(n)
            item => Assert.Equal(item, _linkedList.Tail.Value)  // O(1)

            );
        }

        [Fact]
        public void AddAfter_ArgumentException_Test()
        {
            // Arrenge
            var node = new DoublyLinkedListNode<char>('x');
            // Act & Assert
            Assert.Throws<ArgumentException>(()=> _linkedList.AddBefore(node, node.Value));
        }

        [Fact]
        public void Coutn_Test()
        {
            // act 
            int count = _linkedList.Count;
            // assert
            Assert.Equal(count, 2);
        }
    }
}