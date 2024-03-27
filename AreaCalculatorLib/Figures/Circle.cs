using AreaCalculatorLib.Figures.Interfaces;

namespace AreaCalculatorLib.Figures;

public class Circle : IFigure
{
    public double R { get; }

    public Circle(double r)
    {
        if (r <= 0)
            throw new ArgumentOutOfRangeException(nameof(r), r, "Parameter 'r' should be greater then 0.");

        R = r;
    }

    public double GetArea() => Math.PI * R * R;
}