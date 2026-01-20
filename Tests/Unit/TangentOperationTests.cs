using NUnit.Framework;
using Core.Operations;
using Calculator.Tests.Fixtures;

namespace Calculator.Tests.Unit;

/// <summary>
/// Unit tests for TanOperation
/// Tests tangent function with special angles, common angles, and edge cases
/// Note: Tangent is undefined at pi/2, 3pi/2, etc.
/// </summary>
[TestFixture]
public class TangentOperationTests : CalculatorOperationTestsBase
{
    [SetUp]
    public override void Setup()
    {
        Operation = new TanOperation();
    }

    [Test]
    public override void OperatorType_ReturnsCorrectType()
    {
        Assert.That(Operation!.OperatorType, Is.EqualTo("Tan"));
    }

    [TestCaseSource(typeof(ArithmeticTestData), nameof(ArithmeticTestData.TangentTestCases))]
    public void Execute_DoubleOperands(double[] operands, double expected)
    {
        // Act
        double result = Operation!.Execute(operands);

        // Assert - use larger tolerance for tangent due to precision near asymptotes
        Assert.That(result, Is.EqualTo(expected).Within(0.001));
    }

    /// <summary>
    /// Test tangent near undefined points (pi/2, 3pi/2)
    /// These will produce very large values due to floating point limits
    /// </summary>
    [Test]
    public void Execute_NearUndefinedPoint_ReturnsLargeValue()
    {
        // Arrange - value very close to pi/2
        double[] operands = { Math.PI / 2 - 0.0001 };

        // Act
        double result = Operation!.Execute(operands);

        // Assert - should be a very large positive number
        Assert.That(result, Is.GreaterThan(1000));
    }

    protected override IEnumerable<TestCaseData> GetIntegerTestCases()
    {
        // Tangent works with doubles/radians, not integers
        yield break;
    }

    protected override IEnumerable<TestCaseData> GetDoubleTestCases()
    {
        return ArithmeticTestData.TangentTestCases();
    }
}
