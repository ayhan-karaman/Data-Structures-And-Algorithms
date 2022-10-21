using DataStructures.Queue;
using Xunit;

namespace Tests.DataStructuresTests.ArrayTests
{
    public class LinkedListQueueTests
    {
        private readonly LinkedListQueue<int> _linkedListQueue;
        public LinkedListQueueTests()
        {
            _linkedListQueue = new LinkedListQueue<int>(new int[] {10, 20, 30});
        }
        [Fact]
        public void Count_Test()
        {
            // Act
            var count = _linkedListQueue.Count;

            // Assert
            Assert.Equal(count, 3);
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
            _linkedListQueue.EnQueue(value);

            // assert
            Assert.Equal(4, _linkedListQueue.Count);
            Assert.Collection(_linkedListQueue, 
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
           var result = _linkedListQueue.DeQueue();
            // Assert
            Assert.Equal(10, result);
            Assert.Collection(_linkedListQueue, 
            item => Assert.Equal(item, 20),
            item => Assert.Equal(item, 30)
            );
            Assert.Equal(2, _linkedListQueue.Count);

        }

        [Fact]
        public void DeQueue_EmptyQueueException_Test()
        {
            // Act
            _linkedListQueue.DeQueue();
            _linkedListQueue.DeQueue();
            _linkedListQueue.DeQueue();
            // Assert
            Assert.Throws<EmptyQueueException>(() => _linkedListQueue.DeQueue());
        }

        [Fact]
        public void Peek_Test()
        {
            // Act
            var peek = _linkedListQueue.Peek();
            // Assert
            Assert.Equal(3, _linkedListQueue.Count);
            Assert.Equal(10, peek);
        }

        [Fact]
        public void Peek_EmptyQueueException_Test()
        {
            // Act
            _linkedListQueue.DeQueue();
            _linkedListQueue.DeQueue();
            _linkedListQueue.DeQueue();
            // Assert
            Assert.Throws<EmptyQueueException>(()=> _linkedListQueue.Peek());
        }
    }
}