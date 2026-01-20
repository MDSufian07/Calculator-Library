using Core.Interfaces;

namespace Core.Operations;

/// <summary>
/// Subtraction operation (Single Responsibility Principle)
/// </summary>
public class SubtractionOperation : ICalculatorOperation
{
    public string OperatorType => "Sub";

    public T Execute<T>(T[] operands)
    {
        dynamic a = operands[0];
        dynamic b = operands[1];
        return (T)(a - b);
    }
}
