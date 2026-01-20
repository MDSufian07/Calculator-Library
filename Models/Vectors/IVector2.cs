namespace CalculatorApp.Console.Vectors;

/// <summary>
/// Extended interface for 2D vector operations.
/// </summary>
public interface IVector2 : IVector
{
    double X { get; }
    double Y { get; }

    double Dot(IVector2 other);
}