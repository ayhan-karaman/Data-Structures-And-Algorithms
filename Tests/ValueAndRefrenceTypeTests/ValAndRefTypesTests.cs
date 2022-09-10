using ValueAndReferenceTypes;
using Xunit;

namespace ValueAndRefrenceTypeTests;

public class ValAndRefTypesTests
{
    [Fact]
    public void RefTypeTest()
    {
        //Arrenge
        var ref1 = new RefType(){X= 10, Y=20};
        var ref2 = ref1;
        //Act
        ref1.X = 30;

        //Assert
        Assert.Equal(ref1.X, ref2.X);

    }

    [Fact]
    public void ValueTypeTest()
    {
        //Arrenge
        var val1 = new ValueType(){X= 10, Y=20};
        var val2 = val1;
        //Act
        val1.X = 30;

        //Assert
        Assert.NotEqual(val1.X, val2.X);

    }
}