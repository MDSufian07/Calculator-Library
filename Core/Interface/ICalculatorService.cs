namespace Calculator.Core.Interfaces;

/// <summary>
/// Interface for the calculator service (Dependency Inversion Principle)
/// </summary>
public interface ICalculatorService
{
    T Calculate<T>(string operation, params T[] operands) where T : struct;
    IEnumerable<string> GetSupportedOperations();
}
