using Core.Interfaces;

namespace Core.Operations;

/// <summary>
/// Cosine operation for trigonometric calculations
/// </summary>
public class CosOperation : ICalculatorOperation
{
    public string OperatorType => "Cos";

    public T Execute<T>(T[] operands)
    {
        dynamic value = operands[0];
        dynamic result = Math.Cos(value);
        return (T)Convert.ChangeType(result, typeof(T));
    }
}
