using FluentAssertions;

namespace tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var stringVal = "1";
        var oneEqualsOne = (1 == int.Parse(stringVal));
        
        oneEqualsOne.Should().BeTrue();
    }
}