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
        }
    }
}