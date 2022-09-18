using ValueAndReferenceTypes;
using Xunit;

namespace ApplicationsTests.ValueAndRefrenceTypeTests;

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

    [Fact]
     public void RecordTypeTest()
    {
        //Arrenge
        var val1 = new RecordType(3, 5);
        
        //Act
        var val2 = new RecordType(3, 5);
        //Assert
       Assert.Equal(val1, val2);
      

    }

    [Fact]
     public void SwapByVal()
    {
        //Arrenge
        int a = 14, b= 28;
        var val1 = new ValueType();
        //Act
        val1.Swap(a, b);
        //Assert
       Assert.NotEqual(a, 28);
       Assert.NotEqual(b, 14);
      

    }


     [Fact]
     public void SwapByRef()
    {
        //Arrenge
        int a = 14, b= 28;
        var ref1 = new RefType();
        //Act
        ref1.Swap(ref a, ref b);
        //Assert
        Assert.Equal(a, 28);
        Assert.Equal(b, 14);
      

    }

    [Fact]
     public void CheckOutKeyword()
    {
        //Arrenge
        var ref1 = new RefType();
        int a = 50;
       
        //Act
        ref1.CheckOut(out a);
        //Assert
       Assert.Equal(100, a);

    }
}