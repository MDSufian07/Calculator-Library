using NUnit.Framework;
using Core.Operations;
using Calculator.Tests.Fixtures;

namespace Calculator.Tests.Unit;

/// <summary>
/// Unit tests for DivisionOperation
/// Uses scalable test data from fixtures for comprehensive coverage
/// Includes edge cases and exception handling
/// </summary>
[TestFixture]
public class DivisionOperationTests : CalculatorOperationTestsBase
{
    [SetUp]
    public override void Setup()
    {
        Operation = new DivisionOperation();
    }

    [Test]
    public override void OperatorType_ReturnsCorrectType()
    {
        Assert.That(Operation!.OperatorType, Is.EqualTo("Div"));
    }

    [TestCaseSource(typeof(ArithmeticTestData), nameof(ArithmeticTestData.DivisionTestCases))]
    public void Execute_IntegerOperands(int[] operands, int expected)
    {
        // Act
        int result = Operation!.Execute(operands);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCaseSource(typeof(ArithmeticTestData), nameof(ArithmeticTestData.DivisionDoubleTestCases))]
    public void Execute_DoubleOperands(double[] operands, double expected)
    {
        // Act
        double result = Operation!.Execute(operands);

        // Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.01));
    }

    /// <summary>
    /// Division by zero should throw DivideByZeroException
    /// </summary>
    [TestCaseSource(typeof(ArithmeticTestData), nameof(ArithmeticTestData.DivisionByZeroTestCases))]
    public void Execute_DivisionByZero_ThrowsException(int[] operands)
    {
        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => Operation!.Execute(operands));
    }

    /// <summary>
    /// Verify the exact error message for division by zero
    /// </summary>
    [Test]
    public void Execute_DivisionByZero_HasCorrectErrorMessage()
    {
        // Arrange
        int[] operands = { 10, 0 };

        // Act & Assert
        var exception = Assert.Throws<DivideByZeroException>(() => Operation!.Execute(operands));
        Assert.That(exception!.Message, Is.EqualTo("Cannot divide by zero"));
    }

    protected override IEnumerable<TestCaseData> GetIntegerTestCases()
    {
        return ArithmeticTestData.DivisionTestCases();
    }

    protected override IEnumerable<TestCaseData> GetDoubleTestCases()
    {
        return ArithmeticTestData.DivisionDoubleTestCases();
    }
}
