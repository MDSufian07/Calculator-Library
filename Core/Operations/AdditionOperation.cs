using Core.Interfaces;

namespace Core.Operations;

/// <summary>
/// Addition operation (Single Responsibility Principle)
/// </summary>
public class AdditionOperation : ICalculatorOperation
{
    public string OperatorType => "Add";

    public T Execute<T>(T[] operands)
    {
        dynamic a = operands[0];
        dynamic b = operands[1];
        return (T)(a + b);
    }
}
