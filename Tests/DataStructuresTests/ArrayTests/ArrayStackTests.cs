using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataStructures.Stack;
using DataStructures.Stack.Contracts;
using Xunit;

namespace Tests.DataStructuresTests.ArrayTests
{
    public class ArrayStackTests
    {
        private readonly IStack<char>  _arrayStack;
        public ArrayStackTests()
        {
            _arrayStack = new ArrayStack<char>(new char[] {'s', 'e', 'l', 'a', 'm'});
        }
        [Fact]
        public void Count_Test()
        {
            // act
            var count = _arrayStack.Count;

            // assert
            Assert.Equal(5, count);
        }

        [Fact]
        public void Pop_Test()
        {
            // act
            var result =  _arrayStack.Pop();

            // assert
            Assert.Equal(result, 'm');
            
            Assert.Collection(_arrayStack,
            item => Assert.Equal(item, 's'),
            item => Assert.Equal(item, 'e'),
            item => Assert.Equal(item, 'l'),
            item => Assert.Equal(item, 'a')
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
            _arrayStack.Push(value);

            // assert
            Assert.Equal(value, _arrayStack.Peek());
           
        }
    }
}