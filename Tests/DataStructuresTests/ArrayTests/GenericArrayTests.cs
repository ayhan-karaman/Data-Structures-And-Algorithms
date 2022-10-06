using System.Collections.Generic;
using DataStructures.Array.Generic;
using Xunit;

namespace Tests.DataStructuresTests.ArrayTests
{
    public class GenericArrayTests
    {
        private Array<char> _array;

        public GenericArrayTests()
        {
            _array = new Array<char>(new List<char>{'g', 'i', 'r', 'e', 's', 'u', 'n'});
        }

        [Theory]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(64)]
        [InlineData(128)]
        [InlineData(256)]
        public void DefaultSize_Tests(int defaultSize)
        {
             // arrenge
            var arr = new Array<char>(defaultSize);
            //act
            var len = arr.Length;

            // assert
            Assert.Equal(len, defaultSize);
        }

        [Fact]
        public void Params_Test()
        {
            // arrenge - act
            var arr = new Array<int> (1, 2, 3, 4);

            // assert
            Assert.Equal(4, arr.Length);
        }

        [Fact]
        public void GetValue_Test()
        {
            //arrenge - act
            var c = _array.GetValue(0);

            // assert
            Assert.Equal(c, 'g');
            Assert.IsType<char>(c);
            Assert.True(c is char);
            Assert.IsType(typeof(char), c);
        }

        [Fact]
        public void SetValue_Test()
        {
            // arrenge - act
            _array.SetValue('G', 0);

            // assert
            Assert.Equal('G', _array.GetValue(0));
        }

         [Theory]
         [InlineData(32)]
         [InlineData(64)]
         [InlineData(128)]
         [InlineData(256)]
         public void Generic_Array_Remove_Test(int len)
         {
             //arrenge
            var _arrayList = new Array<int>();
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
         public void Generic_Array_IndexOf_Test()
         {
            // act
            var result = _array.IndexOf('i');
            // assert
            Assert.Equal(1, result);
         }

         [Fact]
         public void ForEach_Test()
         {
            // act
            string s = "";
            foreach (var item in _array)
            {
                s += item;
            } 

            // assert
            Assert.Equal("giresun", s);
         }

    }
}