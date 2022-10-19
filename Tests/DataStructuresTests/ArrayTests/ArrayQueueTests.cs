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
    }
}

