namespace Core.Interfaces;

/// <summary>
/// Interface for calculator operations (Interface Segregation Principle)
/// </summary>
public interface ICalculatorOperation
{
    T Execute<T>(T[] operands);
    string OperatorType { get; }
}
