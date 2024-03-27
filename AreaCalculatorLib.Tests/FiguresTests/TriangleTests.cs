using AreaCalculatorLib.Figures;

namespace AreaCalculatorLib.Tests.FiguresTests;

public class TriangleTests
{
    [Fact]
    public void Constructor_ThrowsException_ForNonPositiveArguments()
    {
        var createNewTriangle_With_a_0 = () => new Triangle(a: 0, b: 1, c: 2);
        var createNewTriangle_With_b_0 = () => new Triangle(a: 1, b: 0, c: 2);
        var createNewTriangle_With_c_0 = () => new Triangle(a: 1, b: 1, c: 0);
        var createNewTriangle_WithNegative_a = () => new Triangle(a: -1, b: 1, c: 2);
        var createNewTriangle_WithNegative_b = () => new Triangle(a: 1, b: -1, c: 2);
        var createNewTriangle_WithNegative_c = () => new Triangle(a: 1, b: 1, c: -1);

        Assert.Throws<ArgumentOutOfRangeException>(createNewTriangle_With_a_0);
        Assert.Throws<ArgumentOutOfRangeException>(createNewTriangle_With_b_0);
        Assert.Throws<ArgumentOutOfRangeException>(createNewTriangle_With_c_0);
        Assert.Throws<ArgumentOutOfRangeException>(createNewTriangle_WithNegative_a);
        Assert.Throws<ArgumentOutOfRangeException>(createNewTriangle_WithNegative_b);
        Assert.Throws<ArgumentOutOfRangeException>(createNewTriangle_WithNegative_c);
    }

    [Fact]
    public void Constructor_ThrowsException_ForArguments_abc_1_1_2()
    {
        var createNewTriangle = () => new Triangle(a: 1, b: 1, c: 2);

        Assert.Throws<ArgumentException>(createNewTriangle);
    }

    [Fact]
    public void GetArea_Returns6_ForTriangleWithABC_3_4_5()
    {
        var triangle = new Triangle(a: 3, b: 4, c: 5);
        const double ExpectedValue = 6;

        var result = triangle.GetArea();

        Assert.Equal(ExpectedValue, result);
    }

    [Fact]
    public void IsRight_ReturnsTrue_ForTriangleWithABC_3_4_5()
    {
        var triangle = new Triangle(a: 3, b: 4, c: 5);

        var result = triangle.IsRight();

        Assert.True(result);
    }

    [Fact]
    public void IsRight_ReturnsFalse_ForTriangleWithABC_2_4_5()
    {
        var triangle = new Triangle(a: 2, b: 4, c: 5);

        var result = triangle.IsRight();

        Assert.False(result);
    }
}