using NUnit.Framework;

namespace Calculator.Tests.Fixtures;

/// <summary>
/// Test data for arithmetic operations
/// Provides comprehensive test cases covering edge cases and common scenarios
/// </summary>
public static class ArithmeticTestData
{
    /// <summary>
    /// Common operand pairs for testing
    /// </summary>
    public static class Operands
    {
        // Basic positive numbers
        public static readonly int[] PositiveSmall_5_3 = { 5, 3 };
        public static readonly int[] PositiveLarge_100_50 = { 100, 50 };

        // Negative numbers
        public static readonly int[] NegativeSmall_Neg5_Neg3 = { -5, -3 };
        public static readonly int[] NegativeLarge_Neg100_Neg50 = { -100, -50 };

        // Mixed signs
        public static readonly int[] Mixed_Positive_Negative = { 10, -7 };
        public static readonly int[] Mixed_Negative_Positive = { -10, 7 };

        // Zero cases
        public static readonly int[] Zero_First = { 0, 5 };
        public static readonly int[] Zero_Second = { 5, 0 };
        public static readonly int[] Zero_Both = { 0, 0 };

        // Edge cases
        public static readonly int[] One_First = { 1, 5 };
        public static readonly int[] One_Second = { 5, 1 };

        // Double precision
        public static readonly double[] Decimal_2_5_3_7 = { 2.5, 3.7 };
        public static readonly double[] Decimal_7_5_2_5 = { 7.5, 2.5 };
        public static readonly double[] Decimal_Negative = { -2.5, -3.7 };
        public static readonly double[] Decimal_Mixed = { -2.5, 3.7 };
    }

    /// <summary>
    /// Addition test cases
    /// </summary>
    public static IEnumerable<TestCaseData> AdditionTestCases()
    {
        yield return new TestCaseData(new int[] { 5, 3 }, 8).SetName("Addition_Positive_5_Plus_3");
        yield return new TestCaseData(new int[] { -5, -3 }, -8).SetName("Addition_Negative_Neg5_Plus_Neg3");
        yield return new TestCaseData(new int[] { 10, -7 }, 3).SetName("Addition_Mixed_10_Plus_Neg7");
        yield return new TestCaseData(new int[] { 0, 5 }, 5).SetName("Addition_ZeroFirst_0_Plus_5");
        yield return new TestCaseData(new int[] { 5, 0 }, 5).SetName("Addition_ZeroSecond_5_Plus_0");
        yield return new TestCaseData(new int[] { 0, 0 }, 0).SetName("Addition_ZeroBoth_0_Plus_0");
        yield return new TestCaseData(new int[] { 100, 50 }, 150).SetName("Addition_LargeNumbers_100_Plus_50");
        yield return new TestCaseData(new int[] { -100, -50 }, -150).SetName("Addition_LargeNegatives_Neg100_Plus_Neg50");
    }

    /// <summary>
    /// Subtraction test cases
    /// </summary>
    public static IEnumerable<TestCaseData> SubtractionTestCases()
    {
        yield return new TestCaseData(new int[] { 10, 3 }, 7).SetName("Subtraction_Positive_10_Minus_3");
        yield return new TestCaseData(new int[] { -5, -3 }, -2).SetName("Subtraction_Negative_Neg5_Minus_Neg3");
        yield return new TestCaseData(new int[] { 10, -7 }, 17).SetName("Subtraction_Mixed_10_Minus_Neg7");
        yield return new TestCaseData(new int[] { 5, 0 }, 5).SetName("Subtraction_ZeroSecond_5_Minus_0");
        yield return new TestCaseData(new int[] { 0, 5 }, -5).SetName("Subtraction_ZeroFirst_0_Minus_5");
        yield return new TestCaseData(new int[] { 0, 0 }, 0).SetName("Subtraction_ZeroBoth_0_Minus_0");
        yield return new TestCaseData(new int[] { 100, 50 }, 50).SetName("Subtraction_LargeNumbers_100_Minus_50");
    }

    /// <summary>
    /// Multiplication test cases
    /// </summary>
    public static IEnumerable<TestCaseData> MultiplicationTestCases()
    {
        yield return new TestCaseData(new int[] { 5, 3 }, 15).SetName("Multiplication_Positive_5_Times_3");
        yield return new TestCaseData(new int[] { -5, -3 }, 15).SetName("Multiplication_Negative_Neg5_Times_Neg3");
        yield return new TestCaseData(new int[] { -5, 3 }, -15).SetName("Multiplication_Mixed_Neg5_Times_3");
        yield return new TestCaseData(new int[] { 5, 0 }, 0).SetName("Multiplication_ByZero_5_Times_0");
        yield return new TestCaseData(new int[] { 5, 1 }, 5).SetName("Multiplication_ByOne_5_Times_1");
        yield return new TestCaseData(new int[] { 0, 0 }, 0).SetName("Multiplication_ZeroBoth_0_Times_0");
        yield return new TestCaseData(new int[] { 10, 10 }, 100).SetName("Multiplication_Perfect_10_Times_10");
        yield return new TestCaseData(new int[] { 100, 50 }, 5000).SetName("Multiplication_Large_100_Times_50");
    }

    /// <summary>
    /// Division test cases (excluding division by zero)
    /// </summary>
    public static IEnumerable<TestCaseData> DivisionTestCases()
    {
        yield return new TestCaseData(new int[] { 10, 2 }, 5).SetName("Division_Positive_10_Divided_2");
        yield return new TestCaseData(new int[] { -10, -2 }, 5).SetName("Division_Negative_Neg10_Divided_Neg2");
        yield return new TestCaseData(new int[] { -10, 2 }, -5).SetName("Division_Mixed_Neg10_Divided_2");
        yield return new TestCaseData(new int[] { 5, 1 }, 5).SetName("Division_ByOne_5_Divided_1");
        yield return new TestCaseData(new int[] { 0, 5 }, 0).SetName("Division_ZeroNumerator_0_Divided_5");
        yield return new TestCaseData(new int[] { 100, 10 }, 10).SetName("Division_Large_100_Divided_10");
        yield return new TestCaseData(new int[] { 100, 4 }, 25).SetName("Division_Perfect_100_Divided_4");
    }

    /// <summary>
    /// Division by zero test cases - should throw exception
    /// </summary>
    public static IEnumerable<TestCaseData> DivisionByZeroTestCases()
    {
        yield return new TestCaseData(new int[] { 10, 0 }).SetName("DivisionByZero_Positive_10_Divided_0");
        yield return new TestCaseData(new int[] { -10, 0 }).SetName("DivisionByZero_Negative_Neg10_Divided_0");
        yield return new TestCaseData(new int[] { 0, 0 }).SetName("DivisionByZero_Zero_0_Divided_0");
    }

    /// <summary>
    /// Double precision test cases for addition
    /// </summary>
    public static IEnumerable<TestCaseData> AdditionDoubleTestCases()
    {
        yield return new TestCaseData(new double[] { 2.5, 3.7 }, 6.2).SetName("Addition_Double_2.5_Plus_3.7");
        yield return new TestCaseData(new double[] { -2.5, -3.7 }, -6.2).SetName("Addition_Double_Neg2.5_Plus_Neg3.7");
        yield return new TestCaseData(new double[] { 0.5, 0.5 }, 1.0).SetName("Addition_Double_0.5_Plus_0.5");
    }

    /// <summary>
    /// Double precision test cases for subtraction
    /// </summary>
    public static IEnumerable<TestCaseData> SubtractionDoubleTestCases()
    {
        yield return new TestCaseData(new double[] { 7.5, 2.3 }, 5.2).SetName("Subtraction_Double_7.5_Minus_2.3");
        yield return new TestCaseData(new double[] { -7.5, -2.3 }, -5.2).SetName("Subtraction_Double_Neg7.5_Minus_Neg2.3");
    }

    /// <summary>
    /// Double precision test cases for multiplication
    /// </summary>
    public static IEnumerable<TestCaseData> MultiplicationDoubleTestCases()
    {
        yield return new TestCaseData(new double[] { 2.5, 4.0 }, 10.0).SetName("Multiplication_Double_2.5_Times_4.0");
        yield return new TestCaseData(new double[] { -2.5, 4.0 }, -10.0).SetName("Multiplication_Double_Neg2.5_Times_4.0");
    }

    /// <summary>
    /// Double precision test cases for division
    /// </summary>
    public static IEnumerable<TestCaseData> DivisionDoubleTestCases()
    {
        yield return new TestCaseData(new double[] { 7.5, 2.5 }, 3.0).SetName("Division_Double_7.5_Divided_2.5");
        yield return new TestCaseData(new double[] { -7.5, 2.5 }, -3.0).SetName("Division_Double_Neg7.5_Divided_2.5");
    }
}
