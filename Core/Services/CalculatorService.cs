using Core.Interfaces;

namespace Core.Services;

/// <summary>
/// Calculator service implementing business logic
/// Follows Dependency Inversion, Open/Closed, and DRY principles
/// </summary>
public class CalculatorService : ICalculatorService
{
    private readonly Dictionary<string, ICalculatorOperation> _operations;

    /// <summary>
    /// Constructor with dependency injection (Dependency Inversion Principle)
    /// </summary>
    public CalculatorService(IEnumerable<ICalculatorOperation> operations)
    {
        // DRY: Single place to manage operations
        _operations = operations.ToDictionary(op => op.OperatorType, op => op);
    }

    public T Calculate<T>(string operation, T[] operands) where T : struct
    {
        if (string.IsNullOrWhiteSpace(operation))
        {
            throw new ArgumentException("Operation cannot be null or empty", nameof(operation));
        }

        if (!_operations.ContainsKey(operation))
        {
            throw new InvalidOperationException(
                $"Unsupported operation: {operation}. Supported operations: {string.Join(", ", _operations.Keys)}");
        }

        // Open/Closed: Adding new operations doesn't require modifying this method
        return _operations[operation].Execute<T>(operands);


    }

    public IEnumerable<string> GetSupportedOperations()
    {
        return _operations.Keys.OrderBy(k => k);
    }
}
