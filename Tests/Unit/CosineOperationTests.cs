using NUnit.Framework;
using Core.Operations;
using Calculator.Tests.Fixtures;

namespace Calculator.Tests.Unit;

/// <summary>
/// Unit tests for CosOperation
/// Tests cosine function with special angles, common angles, and edge cases
/// </summary>
[TestFixture]
public class CosineOperationTests : CalculatorOperationTestsBase
{
    [SetUp]
    public override void Setup()
    {
        Operation = new CosOperation();
    }

    [Test]
    public override void OperatorType_ReturnsCorrectType()
    {
        Assert.That(Operation!.OperatorType, Is.EqualTo("Cos"));
    }

    [TestCaseSource(typeof(ArithmeticTestData), nameof(ArithmeticTestData.CosineTestCases))]
    public void Execute_DoubleOperands(double[] operands, double expected)
    {
        // Act
        double result = Operation!.Execute(operands);

        // Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.0001));
    }

    protected override IEnumerable<TestCaseData> GetIntegerTestCases()
    {
        // Cosine works with doubles/radians, not integers
        yield break;
    }

    protected override IEnumerable<TestCaseData> GetDoubleTestCases()
    {
        return ArithmeticTestData.CosineTestCases();
    }
}
