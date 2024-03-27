using AreaCalculatorLib.Figures.Interfaces;

namespace AreaCalculatorLib;

public class AreaCalculator
{
    public double Calculate(IFigure figure) => figure.GetArea();
}