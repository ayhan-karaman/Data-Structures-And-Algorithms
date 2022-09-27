using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataStructures.Array;
using Xunit;

namespace Tests.DataStructuresTests.ArrayTests
{
    public class ArrayListTests
    {
        private readonly ArrayList _arrayList;

        public ArrayListTests()
        {
             //Arrange
            _arrayList = new ArrayList();
        }

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(64)]
        public void ArrayList_Construtor_Tests(int defaultSize)
        {
            //Arrenge || Act
            var _arrayList = new ArrayList(defaultSize);
            // Assert
            Assert.Equal(_arrayList.Length, defaultSize);
        }

        [Fact]
        public void ArrayList_Add_Test()
        {
            //act
            for (int i = 0; i < 20; i++)
            {
                _arrayList.Add(i);
            }

            //assert
            Assert.Equal(32, _arrayList.Length);
        }
        
         [Theory]
         [InlineData(32)]
         [InlineData(64)]
         [InlineData(128)]
         [InlineData(256)]
         public void ArrayList_Remove_Test(int len)
         {
             //arrenge
            for (int i = 0; i < len; i++)
            {
                _arrayList.Add(i);
            }
             
             Assert.Equal(len, _arrayList.Length);

            for (int i = _arrayList.Length -1; i > 4; i--)
            {
                _arrayList.Remove();
            }
            //assert
            Assert.Equal(16, _arrayList.Length);
         }

         [Fact]
         public void ForEach_Test()
         {
            //arrenge
            _arrayList.Add("a");
            _arrayList.Add("b");
            _arrayList.Add("c");
            _arrayList.Add("d");

            

            // act
            _arrayList.Remove();
            _arrayList.Remove();

            string s = "";
            foreach (var item in _arrayList)
            {
                s += item;
            } 

            // assert
            Assert.Equal("ab", s);
         }


    }
}