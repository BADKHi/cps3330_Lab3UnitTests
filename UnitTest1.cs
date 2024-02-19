using Xunit;
using MekhiRootLib;
namespace MekhiRootLibTest;

public class UnitTest1
{
    [Fact]
    public void Test1Max()
    {
        double a = 31;
        double b = 12;

        double expected = a;

        double actual = Class1.MyMax(a, b);
        Assert.Equal(expected, actual);

    }
    [Fact]
    public void Test2Max()
    {
        double a = -11;
        double b = 42;

        double expected = b;

        double actual = Class1.MyMax(a, b);
        Assert.Equal(expected, actual);

    }
}