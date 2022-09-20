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
            //Arrange - Act
            var arr = new DataStructures.Array.Array(defaultSize);
            
            //Assert
            Assert.Equal(arr.Length, defaultSize);
        }

        [Fact]
        public void Check_Array_Constructor_With_Params()
        {
            // Arrange - Act
            var arr = new Array(1, 2, 3, 4, 5);

            //Assert
            Assert.Equal(5, arr.Length);
            
        }

        [Fact]
        public void Get_and_Set_Values_in_Array()
        {
            //Arrange
            var arr = new Array();

            // Act
            arr.SetValue(28, 0);
            arr.SetValue(55, 1);

            //Assert
            Assert.Equal(28, arr.GetValue(0));
            Assert.Equal(55, arr.GetValue(1));
            Assert.Null(arr.GetValue(2));

        }

        [Fact]
        public void Array_Clone_Test()
        {
            //Arrenge
            var arr = new Array(1, 2, 3);

            // Act
            var clonedArr = (Array)arr.Clone(); // || as Array;

            //Assert
            Assert.NotNull(clonedArr);
            Assert.Equal(arr.Length, clonedArr.Length);
            Assert.NotEqual(arr.GetHashCode(), clonedArr.GetHashCode());
        }

        [Fact]
        public void Array_GetEnumerator_Test()
        {
            //arrenge 
            var arr = new Array(10, 20, 30);
            // act
            string str = "";
            foreach (var item in arr)
            {
                str += item;
            }

            //assert
            Assert.Equal("102030", str);
        }

        [Fact]
        public void Array_Custom_GetEnumerator_Test()
        {
            //arrenge 
            var arr = new Array(10, 20, 30);
            // act
            string str = "";
            foreach (var item in arr)
            {
                str += item;
            }

            //assert
            Assert.Equal("102030", str);
        }
    }
}