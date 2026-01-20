using NUnit.Framework;
using Core.Operations;
using Calculator.Tests.Fixtures;

namespace Calculator.Tests.Unit;

/// <summary>
/// Unit tests for SubtractionOperation
/// Uses scalable test data from fixtures for comprehensive coverage
/// </summary>
[TestFixture]
public class SubtractionOperationTests : CalculatorOperationTestsBase
{
    [SetUp]
    public override void Setup()
    {
        Operation = new SubtractionOperation();
    }

    [Test]
    public override void OperatorType_ReturnsCorrectType()
    {
        Assert.That(Operation!.OperatorType, Is.EqualTo("Sub"));
    }

    [TestCaseSource(typeof(ArithmeticTestData), nameof(ArithmeticTestData.SubtractionTestCases))]
    public void Execute_IntegerOperands(int[] operands, int expected)
    {
        // Act
        int result = Operation!.Execute(operands);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCaseSource(typeof(ArithmeticTestData), nameof(ArithmeticTestData.SubtractionDoubleTestCases))]
    public void Execute_DoubleOperands(double[] operands, double expected)
    {
        // Act
        double result = Operation!.Execute(operands);

        // Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.01));
    }

    protected override IEnumerable<TestCaseData> GetIntegerTestCases()
    {
        return ArithmeticTestData.SubtractionTestCases();
    }

    protected override IEnumerable<TestCaseData> GetDoubleTestCases()
    {
        return ArithmeticTestData.SubtractionDoubleTestCases();
    }
}
