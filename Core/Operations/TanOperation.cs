using Core.Interfaces;

namespace Core.Operations;

/// <summary>
/// Tangent operation for trigonometric calculations
/// </summary>
public class TanOperation : ICalculatorOperation
{
    public string OperatorType => "Tan";

    public T Execute<T>(T[] operands)
    {
        dynamic value = operands[0];
        dynamic result = Math.Tan(value);
        return (T)Convert.ChangeType(result, typeof(T));
    }
}
