using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataStructures.Stack;
using DataStructures.Stack.Contracts;
using Xunit;

namespace Tests.DataStructuresTests.ArrayTests
{
    public class LinkedListStackTests
    {
        private readonly IStack<char>  _linkedListStack;
        public LinkedListStackTests()
        {
            _linkedListStack = new LinkedListStack<char>(new char[] {'s', 'e', 'l', 'a', 'm'});
        }
        [Fact]
        public void Count_Test()
        {
            // act
            var count = _linkedListStack.Count;

            // assert
            Assert.Equal(5, count);
        }

        [Fact]
        public void Pop_Test()
        {
            // act
            var result =  _linkedListStack.Pop();

            // assert
            Assert.Equal(result, 'm');
            
            Assert.Collection(_linkedListStack,
            item => Assert.Equal(item, 'a'),
            item => Assert.Equal(item, 'l'),
            item => Assert.Equal(item, 'e'),
            item => Assert.Equal(item, 's')
            );
        } 

        [Theory]
        [InlineData('m')]
        [InlineData('e')]
        [InlineData('r')]
        [InlineData('h')]
        [InlineData('a')]
        [InlineData('b')]
        [InlineData('a')]
        public void Push_Tests(char value)
        {
            // act
            _linkedListStack.Push(value);

            // assert
            Assert.Equal(value, _linkedListStack.Peek());
        }
    }
}