using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataStructures.Array;
using Xunit;
namespace ArrayTests
{
    public class ArrayTests
    {
        [Theory]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(64)]
        [InlineData(128)]
        [InlineData(256)]
        public void Check_Array_Constructor(int defaultSize)
        {
            //Arrange || Act
            var arr = new Array(defaultSize);
            
            //Assert
            Assert.Equal(arr.Length, defaultSize);
        }
    }
}