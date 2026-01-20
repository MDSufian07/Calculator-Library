using NUnit.Framework;

namespace Calculator.Tests.Fixtures;

/// <summary>
/// Comprehensive test data for all calculator operations
/// Provides exhaustive test cases to identify missing functionality
/// </summary>
public static class ArithmeticTestData
{
    // ==================== BINARY OPERATIONS (Addition, Subtraction, Multiplication, Division) ====================

    #region Addition Test Cases

    /// <summary>
    /// Addition test cases covering: positive, negative, mixed, zero, large numbers, edge cases
    /// </summary>
    public static IEnumerable<TestCaseData> AdditionTestCases()
    {
        // Positive numbers
        yield return new TestCaseData(new int[] { 5, 3 }, 8).SetName("Addition_Positive_5_Plus_3");
        yield return new TestCaseData(new int[] { 1, 1 }, 2).SetName("Addition_Positive_1_Plus_1");
        yield return new TestCaseData(new int[] { 100, 200 }, 300).SetName("Addition_LargePositive_100_Plus_200");

        // Negative numbers
        yield return new TestCaseData(new int[] { -5, -3 }, -8).SetName("Addition_Negative_Neg5_Plus_Neg3");
        yield return new TestCaseData(new int[] { -100, -50 }, -150).SetName("Addition_LargeNegative_Neg100_Plus_Neg50");

        // Mixed signs
        yield return new TestCaseData(new int[] { 10, -7 }, 3).SetName("Addition_Mixed_10_Plus_Neg7");
        yield return new TestCaseData(new int[] { -10, 7 }, -3).SetName("Addition_Mixed_Neg10_Plus_7");

        // Zero cases
        yield return new TestCaseData(new int[] { 0, 5 }, 5).SetName("Addition_ZeroFirst_0_Plus_5");
        yield return new TestCaseData(new int[] { 5, 0 }, 5).SetName("Addition_ZeroSecond_5_Plus_0");
        yield return new TestCaseData(new int[] { 0, 0 }, 0).SetName("Addition_ZeroBoth_0_Plus_0");

        // Commutative property verification
        yield return new TestCaseData(new int[] { 7, 3 }, 10).SetName("Addition_Commutative_7_Plus_3");
        yield return new TestCaseData(new int[] { 3, 7 }, 10).SetName("Addition_Commutative_3_Plus_7");
    }

    /// <summary>
    /// Addition double precision test cases
    /// </summary>
    public static IEnumerable<TestCaseData> AdditionDoubleTestCases()
    {
        yield return new TestCaseData(new double[] { 2.5, 3.7 }, 6.2).SetName("Addition_Double_2.5_Plus_3.7");
        yield return new TestCaseData(new double[] { -2.5, -3.7 }, -6.2).SetName("Addition_Double_Negative");
        yield return new TestCaseData(new double[] { 0.1, 0.2 }, 0.3).SetName("Addition_Double_Precision_0.1_Plus_0.2");
    }

    #endregion

    #region Subtraction Test Cases

    /// <summary>
    /// Subtraction test cases covering: positive, negative, mixed, zero, edge cases
    /// </summary>
    public static IEnumerable<TestCaseData> SubtractionTestCases()
    {
        // Positive numbers
        yield return new TestCaseData(new int[] { 10, 5 }, 5).SetName("Subtraction_Positive_10_Minus_5");
        yield return new TestCaseData(new int[] { 7, 7 }, 0).SetName("Subtraction_Equal_7_Minus_7");
        yield return new TestCaseData(new int[] { 100, 50 }, 50).SetName("Subtraction_LargePositive_100_Minus_50");

        // Negative numbers
        yield return new TestCaseData(new int[] { -5, -3 }, -2).SetName("Subtraction_Negative_Neg5_Minus_Neg3");
        yield return new TestCaseData(new int[] { -100, -50 }, -50).SetName("Subtraction_LargeNegative_Neg100_Minus_Neg50");

        // Mixed signs
        yield return new TestCaseData(new int[] { 10, -5 }, 15).SetName("Subtraction_Mixed_10_Minus_Neg5");
        yield return new TestCaseData(new int[] { -10, 5 }, -15).SetName("Subtraction_Mixed_Neg10_Minus_5");

        // Zero cases
        yield return new TestCaseData(new int[] { 5, 0 }, 5).SetName("Subtraction_ZeroSecond_5_Minus_0");
        yield return new TestCaseData(new int[] { 0, 5 }, -5).SetName("Subtraction_ZeroFirst_0_Minus_5");
        yield return new TestCaseData(new int[] { 0, 0 }, 0).SetName("Subtraction_ZeroBoth_0_Minus_0");

        // Non-commutative property verification
        yield return new TestCaseData(new int[] { 7, 3 }, 4).SetName("Subtraction_NonCommutative_7_Minus_3");
        yield return new TestCaseData(new int[] { 3, 7 }, -4).SetName("Subtraction_NonCommutative_3_Minus_7");
    }

    /// <summary>
    /// Subtraction double precision test cases
    /// </summary>
    public static IEnumerable<TestCaseData> SubtractionDoubleTestCases()
    {
        yield return new TestCaseData(new double[] { 5.7, 2.3 }, 3.4).SetName("Subtraction_Double_5.7_Minus_2.3");
        yield return new TestCaseData(new double[] { -5.7, -2.3 }, -3.4).SetName("Subtraction_Double_Negative");
        yield return new TestCaseData(new double[] { 0.3, 0.1 }, 0.2).SetName("Subtraction_Double_Precision");
    }

    #endregion

    #region Multiplication Test Cases

    /// <summary>
    /// Multiplication test cases covering: positive, negative, mixed, zero, identity property, commutative property
    /// </summary>
    public static IEnumerable<TestCaseData> MultiplicationTestCases()
    {
        // Positive numbers
        yield return new TestCaseData(new int[] { 5, 3 }, 15).SetName("Multiplication_Positive_5_Times_3");
        yield return new TestCaseData(new int[] { 7, 8 }, 56).SetName("Multiplication_Positive_7_Times_8");
        yield return new TestCaseData(new int[] { 100, 200 }, 20000).SetName("Multiplication_LargePositive_100_Times_200");

        // Negative numbers
        yield return new TestCaseData(new int[] { -5, -3 }, 15).SetName("Multiplication_Negative_Neg5_Times_Neg3");
        yield return new TestCaseData(new int[] { -10, -10 }, 100).SetName("Multiplication_LargeNegative_Neg10_Times_Neg10");

        // Mixed signs
        yield return new TestCaseData(new int[] { -5, 3 }, -15).SetName("Multiplication_Mixed_Neg5_Times_3");
        yield return new TestCaseData(new int[] { 5, -3 }, -15).SetName("Multiplication_Mixed_5_Times_Neg3");

        // Zero property
        yield return new TestCaseData(new int[] { 5, 0 }, 0).SetName("Multiplication_ZeroProperty_5_Times_0");
        yield return new TestCaseData(new int[] { 0, 100 }, 0).SetName("Multiplication_ZeroProperty_0_Times_100");
        yield return new TestCaseData(new int[] { 0, 0 }, 0).SetName("Multiplication_ZeroProperty_0_Times_0");

        // Identity property
        yield return new TestCaseData(new int[] { 5, 1 }, 5).SetName("Multiplication_IdentityProperty_5_Times_1");
        yield return new TestCaseData(new int[] { 1, 100 }, 100).SetName("Multiplication_IdentityProperty_1_Times_100");
        yield return new TestCaseData(new int[] { 1, 1 }, 1).SetName("Multiplication_IdentityProperty_1_Times_1");

        // Commutative property
        yield return new TestCaseData(new int[] { 4, 6 }, 24).SetName("Multiplication_Commutative_4_Times_6");
        yield return new TestCaseData(new int[] { 6, 4 }, 24).SetName("Multiplication_Commutative_6_Times_4");

        // Negative identity
        yield return new TestCaseData(new int[] { -5, 1 }, -5).SetName("Multiplication_NegativeIdentity_Neg5_Times_1");
    }

    /// <summary>
    /// Multiplication double precision test cases
    /// </summary>
    public static IEnumerable<TestCaseData> MultiplicationDoubleTestCases()
    {
        yield return new TestCaseData(new double[] { 2.5, 3.0 }, 7.5).SetName("Multiplication_Double_2.5_Times_3.0");
        yield return new TestCaseData(new double[] { -2.5, 4.0 }, -10.0).SetName("Multiplication_Double_Negative_Neg2.5_Times_4.0");
        yield return new TestCaseData(new double[] { 0.5, 0.5 }, 0.25).SetName("Multiplication_Double_Precision_0.5_Times_0.5");
    }

    #endregion

    #region Division Test Cases

    /// <summary>
    /// Division test cases covering: positive, negative, mixed, one cases, perfect division
    /// </summary>
    public static IEnumerable<TestCaseData> DivisionTestCases()
    {
        // Positive numbers
        yield return new TestCaseData(new int[] { 10, 2 }, 5).SetName("Division_Positive_10_Divided_2");
        yield return new TestCaseData(new int[] { 9, 3 }, 3).SetName("Division_Positive_9_Divided_3");
        yield return new TestCaseData(new int[] { 100, 10 }, 10).SetName("Division_LargePositive_100_Divided_10");

        // Negative numbers
        yield return new TestCaseData(new int[] { -10, -2 }, 5).SetName("Division_Negative_Neg10_Divided_Neg2");
        yield return new TestCaseData(new int[] { -9, -3 }, 3).SetName("Division_Negative_Neg9_Divided_Neg3");

        // Mixed signs (negative result)
        yield return new TestCaseData(new int[] { -10, 2 }, -5).SetName("Division_Mixed_Neg10_Divided_2");
        yield return new TestCaseData(new int[] { 10, -2 }, -5).SetName("Division_Mixed_10_Divided_Neg2");

        // One cases (identity)
        yield return new TestCaseData(new int[] { 5, 1 }, 5).SetName("Division_IdentityProperty_5_Divided_1");
        yield return new TestCaseData(new int[] { 1, 1 }, 1).SetName("Division_IdentityProperty_1_Divided_1");

        // Zero numerator
        yield return new TestCaseData(new int[] { 0, 5 }, 0).SetName("Division_ZeroNumerator_0_Divided_5");
        yield return new TestCaseData(new int[] { 0, 1 }, 0).SetName("Division_ZeroNumerator_0_Divided_1");

        // Perfect division
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
        yield return new TestCaseData(new int[] { 1, 0 }).SetName("DivisionByZero_One_1_Divided_0");
    }

    /// <summary>
    /// Division double precision test cases
    /// </summary>
    public static IEnumerable<TestCaseData> DivisionDoubleTestCases()
    {
        yield return new TestCaseData(new double[] { 7.5, 2.5 }, 3.0).SetName("Division_Double_7.5_Divided_2.5");
        yield return new TestCaseData(new double[] { -7.5, 2.5 }, -3.0).SetName("Division_Double_Negative_Neg7.5_Divided_2.5");
        yield return new TestCaseData(new double[] { 1.0, 2.0 }, 0.5).SetName("Division_Double_1.0_Divided_2.0");
    }

    #endregion

    // ==================== UNARY OPERATIONS (Sine, Cosine, Tangent) ====================

    #region Sine Test Cases

    /// <summary>
    /// Sine function test cases covering: 0, pi/2, pi, 3pi/2, 2pi, negative angles, common angles
    /// All angles in radians
    /// </summary>
    public static IEnumerable<TestCaseData> SineTestCases()
    {
        // Special angles (in radians)
        yield return new TestCaseData(new double[] { 0 }, 0.0).SetName("Sin_Zero_sin(0)");
        yield return new TestCaseData(new double[] { Math.PI / 2 }, 1.0).SetName("Sin_PiHalf_sin(pi/2)");
        yield return new TestCaseData(new double[] { Math.PI }, 0.0).SetName("Sin_Pi_sin(pi)");
        yield return new TestCaseData(new double[] { 3 * Math.PI / 2 }, -1.0).SetName("Sin_3PiHalf_sin(3pi/2)");
        yield return new TestCaseData(new double[] { 2 * Math.PI }, 0.0).SetName("Sin_2Pi_sin(2pi)");

        // Negative angles
        yield return new TestCaseData(new double[] { -Math.PI / 2 }, -1.0).SetName("Sin_NegPiHalf_sin(-pi/2)");
        yield return new TestCaseData(new double[] { -Math.PI }, 0.0).SetName("Sin_NegPi_sin(-pi)");

        // Common angles
        yield return new TestCaseData(new double[] { Math.PI / 6 }, 0.5).SetName("Sin_Pi6_sin(pi/6)");
        yield return new TestCaseData(new double[] { Math.PI / 4 }, Math.Sqrt(2) / 2).SetName("Sin_Pi4_sin(pi/4)");
        yield return new TestCaseData(new double[] { Math.PI / 3 }, Math.Sqrt(3) / 2).SetName("Sin_Pi3_sin(pi/3)");

        // Decimal values
        yield return new TestCaseData(new double[] { 0.5 }, Math.Sin(0.5)).SetName("Sin_Decimal_sin(0.5)");
    }

    #endregion

    #region Cosine Test Cases

    /// <summary>
    /// Cosine function test cases covering: 0, pi/2, pi, 3pi/2, 2pi, negative angles, common angles
    /// All angles in radians
    /// </summary>
    public static IEnumerable<TestCaseData> CosineTestCases()
    {
        // Special angles (in radians)
        yield return new TestCaseData(new double[] { 0 }, 1.0).SetName("Cos_Zero_cos(0)");
        yield return new TestCaseData(new double[] { Math.PI / 2 }, 0.0).SetName("Cos_PiHalf_cos(pi/2)");
        yield return new TestCaseData(new double[] { Math.PI }, -1.0).SetName("Cos_Pi_cos(pi)");
        yield return new TestCaseData(new double[] { 3 * Math.PI / 2 }, 0.0).SetName("Cos_3PiHalf_cos(3pi/2)");
        yield return new TestCaseData(new double[] { 2 * Math.PI }, 1.0).SetName("Cos_2Pi_cos(2pi)");

        // Negative angles
        yield return new TestCaseData(new double[] { -Math.PI / 2 }, 0.0).SetName("Cos_NegPiHalf_cos(-pi/2)");
        yield return new TestCaseData(new double[] { -Math.PI }, -1.0).SetName("Cos_NegPi_cos(-pi)");

        // Common angles
        yield return new TestCaseData(new double[] { Math.PI / 6 }, Math.Sqrt(3) / 2).SetName("Cos_Pi6_cos(pi/6)");
        yield return new TestCaseData(new double[] { Math.PI / 4 }, Math.Sqrt(2) / 2).SetName("Cos_Pi4_cos(pi/4)");
        yield return new TestCaseData(new double[] { Math.PI / 3 }, 0.5).SetName("Cos_Pi3_cos(pi/3)");

        // Decimal values
        yield return new TestCaseData(new double[] { 0.5 }, Math.Cos(0.5)).SetName("Cos_Decimal_cos(0.5)");
    }

    #endregion

    #region Tangent Test Cases

    /// <summary>
    /// Tangent function test cases covering: 0, special angles, common angles
    /// Note: Tan is undefined at pi/2, 3pi/2, etc. - these tests will produce very large values due to floating point
    /// All angles in radians
    /// </summary>
    public static IEnumerable<TestCaseData> TangentTestCases()
    {
        // Special angles where tan is defined
        yield return new TestCaseData(new double[] { 0 }, 0.0).SetName("Tan_Zero_tan(0)");
        yield return new TestCaseData(new double[] { Math.PI }, 0.0).SetName("Tan_Pi_tan(pi)");
        yield return new TestCaseData(new double[] { 2 * Math.PI }, 0.0).SetName("Tan_2Pi_tan(2pi)");

        // Negative angles
        yield return new TestCaseData(new double[] { -Math.PI }, 0.0).SetName("Tan_NegPi_tan(-pi)");
        yield return new TestCaseData(new double[] { -Math.PI / 4 }, -1.0).SetName("Tan_NegPi4_tan(-pi/4)");

        // Common angles where tan is defined
        yield return new TestCaseData(new double[] { Math.PI / 6 }, 1.0 / Math.Sqrt(3)).SetName("Tan_Pi6_tan(pi/6)");
        yield return new TestCaseData(new double[] { Math.PI / 4 }, 1.0).SetName("Tan_Pi4_tan(pi/4)");
        yield return new TestCaseData(new double[] { Math.PI / 3 }, Math.Sqrt(3)).SetName("Tan_Pi3_tan(pi/3)");

        // Decimal values
        yield return new TestCaseData(new double[] { 0.5 }, Math.Tan(0.5)).SetName("Tan_Decimal_tan(0.5)");
        yield return new TestCaseData(new double[] { 1.0 }, Math.Tan(1.0)).SetName("Tan_One_tan(1)");

        // Note: Tests near undefined points (pi/2, 3pi/2) will result in very large positive/negative values
        // due to floating point precision - this is expected behavior for tangent function
    }

    #endregion
}
