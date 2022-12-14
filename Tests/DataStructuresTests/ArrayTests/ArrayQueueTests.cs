using System;
using DataStructures.Queue;
using Xunit;

namespace Tests.DataStructuresTests.ArrayTests
{
    public class ArrayQueueTests
    {
        private readonly ArrayQueue<int> _arrayQueue;


        public ArrayQueueTests()
        {
            _arrayQueue = new ArrayQueue<int>(new int[] { 10, 20, 30 });
        }

        [Fact]
        public void Count_Test()
        {
            // act
            var count = _arrayQueue.Count;

            // assert
            Assert.Equal(3, count);
        }

        [Theory]
        [InlineData(40)]
        [InlineData(50)]
        [InlineData(60)]
        [InlineData(70)]
        [InlineData(80)]
        public void EnQueue_Tests(int value)
        {
            // act
            _arrayQueue.EnQueue(value);

            // assert
            Assert.Equal(4, _arrayQueue.Count);
            Assert.Collection(_arrayQueue, 
            item => Assert.Equal(item, 10),
            item => Assert.Equal(item, 20),
            item => Assert.Equal(item, 30),
            item => Assert.Equal(item, value)
            );
        }

        [Fact]
        public void DeQueue_Test()
        {
            // Act
           var result = _arrayQueue.DeQueue();
            // Assert
            Assert.Equal(10, result);
            Assert.Collection(_arrayQueue, 
            item => Assert.Equal(item, 20),
            item => Assert.Equal(item, 30)
            );
            Assert.Equal(2, _arrayQueue.Count);

        }

        [Fact]
        public void DeQueue_EmptyQueueException_Test()
        {
            // Act
            _arrayQueue.DeQueue();
            _arrayQueue.DeQueue();
            _arrayQueue.DeQueue();
            // Assert
            Assert.Throws<EmptyQueueException>(() => _arrayQueue.DeQueue());
        }

        [Fact]
        public void Peek_Test()
        {
            // Act
            var peek = _arrayQueue.Peek();
            // Assert
            Assert.Equal(3, _arrayQueue.Count);
            Assert.Equal(10, peek);
        }
        [Fact]
        public void Peek_EmptyQueueException_Test()
        {
            // Act
            _arrayQueue.DeQueue();
            _arrayQueue.DeQueue();
            _arrayQueue.DeQueue();
            var result = _arrayQueue.Peek();
            // Assert
            Assert.Equal(result, default);
        }

        
    }
}

