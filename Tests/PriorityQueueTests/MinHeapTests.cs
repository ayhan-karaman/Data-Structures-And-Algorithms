using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PriorityQueue;
using Xunit;

namespace Tests.PriorityQueueTests
{
    public class MinHeapTests
    {
        private BHeap<int> minHeap { get; set; }
        public MinHeapTests()
        {
            minHeap = new MinHeap<int>(new int[] {1, 2, 3, 4, 5, 6, 7});
        }
        [Fact]
        public void Count_Test()
        {
            // assert
            Assert.True(7 == minHeap.Count);
        }

        [Fact]
        public void GetEnumerator_Test()
        {
            
            // Act
            Assert.Collection(minHeap, 
             item => Assert.Equal(1, item),
             item => Assert.Equal(2, item),
             item => Assert.Equal(3, item),
             item => Assert.Equal(4, item),
             item => Assert.Equal(5, item),
             item => Assert.Equal(6, item),
             item => Assert.Equal(7, item)
            );
        }


       [Theory]
       [InlineData(7)]
       [InlineData(8)]
       [InlineData(9)]
       [InlineData(10)]
       [InlineData(15)]
       public void Add_Tests(int value)
       {
            // act
            minHeap = new MinHeap<int>(new int[] {1, 2, 3, 4, 5, 6, value });
            Assert.Collection(minHeap, 
            item => Assert.Equal(1, item),
             item => Assert.Equal(2, item),
             item => Assert.Equal(3, item),
             item => Assert.Equal(4, item),
             item => Assert.Equal(5, item),
             item => Assert.Equal(6, item),
             item => Assert.Equal(value, item)
            );
            Assert.Equal(value, minHeap.Array.GetValue(minHeap.Count -1));
       }
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void HeapifUp_Tests(int value)
        {
            // act
            minHeap = new MinHeap<int>(new int[] {10, 20, 30, 40, 50, 60, value });

            //assert
            Assert.Collection(minHeap, 
            item => Assert.Equal(value, item),
             item => Assert.Equal(20, item),
             item => Assert.Equal(10, item),
             item => Assert.Equal(40, item),
             item => Assert.Equal(50, item),
             item => Assert.Equal(60, item),
             item => Assert.Equal(30, item)
            );
            Assert.Equal(value, minHeap.Array.GetValue(0));
        }

        [Theory]
        [InlineData(70)]
        [InlineData(80)]
        [InlineData(90)]
        [InlineData(93)]
        [InlineData(98)]
        public void Remove_Tests(int value)
        {
            // act
            minHeap = new MinHeap<int>(new int[] {10, 20, 30, 40, 50, 60, value });
            var removedItem = minHeap.DeleteMinMax();
            // assert
            Assert.Collection(minHeap, 
             item => Assert.Equal(20, item),
             item => Assert.Equal(40, item),
             item => Assert.Equal(30, item),
             item => Assert.Equal(value, item),
             item => Assert.Equal(50, item),
             item => Assert.Equal(60, item)
            );
            Assert.Equal(10, removedItem);
        }

        [Theory]                // i * 2 + 1 = leftChildIndex
        [InlineData(0, 1)]      // 0 * 2 + 1 = 1
        [InlineData(1, 3)]      // 1 * 2 + 1 = 3
        [InlineData(2, 5)]      // 2 * 2 + 1 = 5
        [InlineData(3, 7)]      // 3 * 2 + 1 = 7
        [InlineData(10, 21)]    // 10 * 2 + 1 = 21
        [InlineData(20, 41)]    // 20 * 2 + 1 = 41
        public void GetLeftChildIndex_Tests(int index, int leftChildIndex)
        {
            // act 
            var result = minHeap.GetLeftChildIndex(index);
            // assert
            Assert.Equal(result, leftChildIndex);
        }


        [Theory]                // i * 2 + 2 = rightChildIndex
        [InlineData(0, 2)]      // 0 * 2 + 2 = 2
        [InlineData(1, 4)]      // 1 * 2 + 2 = 4
        [InlineData(2, 6)]      // 2 * 2 + 2 = 6
        [InlineData(3, 8)]      // 3 * 2 + 2 = 8
        [InlineData(10, 22)]    // 10 * 2 + 2 = 22
        [InlineData(20, 42)]    // 20 * 2 + 2 = 42
        public void GetRightChildIndex_Tests(int index, int leftChildIndex)
        {
            // act 
            var result = minHeap.GetRightChildIndex(index);
            // assert
            Assert.Equal(result, leftChildIndex);
        }


        [Theory]
        [InlineData(1, 0)]
        [InlineData(2, 0)]
        [InlineData(10, 4)]
        [InlineData(20, 9)]
        [InlineData(30, 14)]
        public void GetParentIndex_Tests(int index, int parentIndex)
        {
            // act
            var result = minHeap.GetParentIndex(index);
            // assert
            Assert.Equal(result, parentIndex);
        }

    }
}