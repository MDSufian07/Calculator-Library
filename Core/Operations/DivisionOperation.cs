using Core.Interfaces;

namespace Core.Operations;

/// <summary>
/// Division operation with validation (Single Responsibility Principle)
/// </summary>
public class DivisionOperation : ICalculatorOperation
{
    public string OperatorType => "Div";

    public T Execute<T>(T[] operands)
    {
        dynamic b = operands[1];
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero");
        }

        dynamic a = operands[0];
        return (T)(a / b);
    }
}
