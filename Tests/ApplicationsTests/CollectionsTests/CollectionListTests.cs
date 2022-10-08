using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Tests.ApplicationsTests.CollectionsTests
{
    public class CollectionListTests
    {
        private readonly List<int> _leftList;
        private readonly List<int> _rightList;
        public CollectionListTests()
        {
            _leftList = new List<int>{1, 2, 3, 4, 4, 5};
            _rightList = new List<int>{4, 5, 6, 6, 7};
        }

        [Fact]
        public void List_Add_Test()
        {
            // act
            _leftList.Add(10);

           var count = _leftList.Count;

            Assert.Equal(count, 7);
        }

        [Fact]
        public void List_AddRange_Test()
        {
            //act 
            _leftList.AddRange(new int[] {7, 8});

            // assert
            Assert.Collection(_leftList, 
            item => Assert.Equal(item, _leftList[0]),
            item => Assert.Equal(item, _leftList[1]),
            item => Assert.Equal(item, _leftList[2]),
            item => Assert.Equal(item, _leftList[3]),
            item => Assert.Equal(item, _leftList[4]),
            item => Assert.Equal(item, _leftList[5]),
            item => Assert.Equal(item, _leftList[6]),
            item => Assert.Equal(item, _leftList[7])
            );
        }

        [Fact]
        public void InterSection_Test()
        {
            // act
            var interSectionSet = _leftList.Intersect(_rightList);

            // assert
            Assert.Collection(interSectionSet,
             item => Assert.Equal(item, 4),
             item => Assert.Equal(item, 5)
            );
        }

        [Fact]
        public void Union_Test()
        {
            // act
            var unionSet = _leftList.Union(_rightList);

            // assert
            Assert.Collection(unionSet, 
            item => Assert.Equal(item, 1),
            item => Assert.Equal(item, 2),
            item => Assert.Equal(item, 3),
            item => Assert.Equal(item, 4),
            item => Assert.Equal(item, 5),
            item => Assert.Equal(item, 6),
            item => Assert.Equal(item, 7)
            );
        }
    
    
    }
}