using AreaCalculatorLib.Figures.Interfaces;

namespace AreaCalculatorLib.Figures;

public class Triangle : IFigure
{
    public double A { get; }

    public double B { get; }

    public double C { get; }

    public Triangle(double a, double b, double c)
    {
        if (a <= 0)
            throw new ArgumentOutOfRangeException(nameof(a), a, "Parameter 'a' should be greater then 0.");
        if (b <= 0)
            throw new ArgumentOutOfRangeException(nameof(b), b, "Parameter 'b' should be greater then 0.");
        if (c <= 0)
            throw new ArgumentOutOfRangeException(nameof(c), c, "Parameter 'c' should be greater then 0.");

        if (a + b <= c || a + c <= b || b + c <= a)
            throw new ArgumentException(
                "A triangle exists only when the sum of its two sides is greater than the third.");

        (A, B, C) = (a, b, c);
    }

    public bool IsRight()
    {
        var max = Math.Max(A, Math.Max(B, C));

        if (max == A) return Math.Abs(A * A - (B * B + C * C)) < double.Epsilon;

        if (max == B) return Math.Abs(B * B - (A * A + C * C)) < double.Epsilon;

        return Math.Abs(C * C - (A * A + B * B)) < double.Epsilon;
    }

    public double GetArea()
    {
        var p = (A + B + C) / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }
}