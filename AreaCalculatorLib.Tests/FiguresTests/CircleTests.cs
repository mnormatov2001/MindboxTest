using AreaCalculatorLib.Figures;

namespace AreaCalculatorLib.Tests.FiguresTests;

public class CircleTests
{
    [Fact]
    public void Constructor_ThrowsException_ForNonPositiveArgument()
    {
        var createCircle_With_r_0 = () => new Circle(r: 0);
        var createCircle_WithNegative_r = () => new Circle(r: -1);

        Assert.Throws<ArgumentOutOfRangeException>(createCircle_With_r_0);
        Assert.Throws<ArgumentOutOfRangeException>(createCircle_WithNegative_r);
    }

    [Fact]
    public void GetArea_ReturnsPI_ForCircleWithR_1()
    {
        var circle = new Circle(r: 1);
        const double ExpectedValue = Math.PI;

        var result = circle.GetArea();

        Assert.Equal(ExpectedValue, result);
    }

    [Fact]
    public void GetArea_ReturnsCorrectValue()
    {
        const double R = 2;
        const double ExpectedValue = Math.PI * R * R;
        var circle = new Circle(r: R);

        var result = circle.GetArea();

        Assert.Equal(ExpectedValue, result);
    }
}