using NUnit.Framework;
using Core.Operations;
using Calculator.Tests.Fixtures;

namespace Calculator.Tests.Unit;

/// <summary>
/// Unit tests for AdditionOperation
/// Uses scalable test data from fixtures for comprehensive coverage
/// </summary>
[TestFixture]
public class AdditionOperationTests : CalculatorOperationTestsBase
{
    [SetUp]
    public override void Setup()
    {
        Operation = new AdditionOperation();
    }

    [Test]
    public override void OperatorType_ReturnsCorrectType()
    {
        Assert.That(Operation!.OperatorType, Is.EqualTo("Add"));
    }

    [TestCaseSource(typeof(ArithmeticTestData), nameof(ArithmeticTestData.AdditionTestCases))]
    public void Execute_IntegerOperands(int[] operands, int expected)
    {
        // Act
        int result = Operation!.Execute(operands);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCaseSource(typeof(ArithmeticTestData), nameof(ArithmeticTestData.AdditionDoubleTestCases))]
    public void Execute_DoubleOperands(double[] operands, double expected)
    {
        // Act
        double result = Operation!.Execute(operands);

        // Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.01));
    }

    protected override IEnumerable<TestCaseData> GetIntegerTestCases()
    {
        return ArithmeticTestData.AdditionTestCases();
    }

    protected override IEnumerable<TestCaseData> GetDoubleTestCases()
    {
        return ArithmeticTestData.AdditionDoubleTestCases();
    }
}
