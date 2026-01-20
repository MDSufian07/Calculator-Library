using Core.Interfaces;

namespace Core.Operations;

/// <summary>
/// Sine operation for trigonometric calculations
/// </summary>
public class SinOperation : ICalculatorOperation
{
    public string OperatorType => "sin";

    public T Execute<T>(T[] operands)
    {
        dynamic value = operands[0];
        dynamic result = Math.Sin(value);
        return (T)Convert.ChangeType(result, typeof(T));
    }
}
