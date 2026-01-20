using NUnit.Framework;
using Core.Interfaces;

namespace Calculator.Tests.Unit;

/// <summary>
/// Base class for testing calculator operations
/// Provides common structure for all operation tests
/// </summary>
[TestFixture]
public abstract class CalculatorOperationTestsBase
{
    protected ICalculatorOperation? Operation;

    /// <summary>
    /// Subclasses must initialize the operation in SetUp
    /// </summary>
    [SetUp]
    public abstract void Setup();

    /// <summary>
    /// Test that the operation returns the correct operator type
    /// </summary>
    [Test]
    public abstract void OperatorType_ReturnsCorrectType();

    /// <summary>
    /// Subclasses override this to provide integer test cases
    /// </summary>
    protected abstract IEnumerable<TestCaseData> GetIntegerTestCases();

    /// <summary>
    /// Subclasses override this to provide double test cases
    /// </summary>
    protected abstract IEnumerable<TestCaseData> GetDoubleTestCases();
}
