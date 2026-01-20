using NUnit.Framework;
using Core.Operations;
using Calculator.Tests.Fixtures;

namespace Calculator.Tests.Unit;

/// <summary>
/// Unit tests for MultiplicationOperation
/// Uses scalable test data from fixtures for comprehensive coverage
/// </summary>
[TestFixture]
public class MultiplicationOperationTests : CalculatorOperationTestsBase
{
    [SetUp]
    public override void Setup()
    {
        Operation = new MultiplicationOperation();
    }

    [Test]
    public override void OperatorType_ReturnsCorrectType()
    {
        Assert.That(Operation!.OperatorType, Is.EqualTo("Mul"));
    }

    [TestCaseSource(typeof(ArithmeticTestData), nameof(ArithmeticTestData.MultiplicationTestCases))]
    public void Execute_IntegerOperands(int[] operands, int expected)
    {
        // Act
        int result = Operation!.Execute(operands);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCaseSource(typeof(ArithmeticTestData), nameof(ArithmeticTestData.MultiplicationDoubleTestCases))]
    public void Execute_DoubleOperands(double[] operands, double expected)
    {
        // Act
        double result = Operation!.Execute(operands);

        // Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.01));
    }

    protected override IEnumerable<TestCaseData> GetIntegerTestCases()
    {
        return ArithmeticTestData.MultiplicationTestCases();
    }

    protected override IEnumerable<TestCaseData> GetDoubleTestCases()
    {
        return ArithmeticTestData.MultiplicationDoubleTestCases();
    }
}
