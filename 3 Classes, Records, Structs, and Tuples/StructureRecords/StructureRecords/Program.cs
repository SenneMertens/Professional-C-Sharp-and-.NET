Dimensions point1 = new(3, 6);

// Deconstruct.
(double length, _) = point1;

Console.WriteLine(length);

Dimensions point2 = new();
Dimensions point3 = point2 with { Length = 3, Width = 6 };

if (point3 == point1)
{
    Console.WriteLine("Both points have the same values.");
}

public record struct Dimensions(double Length, double Width)
{
    public double Diagonal => Math.Sqrt(Length * Length + Width * Width);
}
