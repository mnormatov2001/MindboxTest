using AreaCalculatorLib.Figures;
using AreaCalculatorLib.Figures.Interfaces;

namespace AreaCalculatorLib.Tests;

public class AreaCalculatorTests
{
    [Fact]
    public void Calculate_Returns6_ForTriangleWithABC_3_4_5()
    {
        var calculator = new AreaCalculator();
        IFigure figure = new Triangle(a: 3, b: 4, c: 5);
        const double ExpectedValue = 6;

        var result = calculator.Calculate(figure);

        Assert.Equal(ExpectedValue, result);
    }

    [Fact]
    public void Calculate_ReturnsCorrectValue_ForCircle()
    {
        const double R = 3;
        const double ExpectedValue = Math.PI * R * R;
        var calculator = new AreaCalculator();
        IFigure figure = new Circle(r: R);

        var result = calculator.Calculate(figure);

        Assert.Equal(ExpectedValue, result);
    }
}