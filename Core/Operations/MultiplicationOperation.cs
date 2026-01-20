using Calculator.Core.Interfaces;

namespace Calculator.Core.Operations;

/// <summary>
/// Multiplication operation (Single Responsibility Principle)
/// </summary>
public class MultiplicationOperation : ICalculatorOperation
{
    public string OperatorType => "Mul";

    public T Execute<T>(T[] operands)
    {
        dynamic a = operands[0];
        dynamic b = operands[1];
        return (T)(a * b);
    }
}
