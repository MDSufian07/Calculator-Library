using NUnit.Framework;

namespace Calculator.Tests.Fixtures;

/// <summary>
/// Comprehensive test data for all calculator operations
/// Provides exhaustive test cases including:
/// - Basic arithmetic (positive, negative, mixed signs)
/// - Boundary conditions (zero, large numbers, min/max values)
/// - Mathematical properties (commutative, identity, zero property)
/// - Floating-point edge cases (very small, very large, precision)
/// - Special angles for trigonometric functions
/// - Error/exception scenarios
/// </summary>
public static class ArithmeticTestData
{
    // ==================== BINARY OPERATIONS (Addition, Subtraction, Multiplication, Division) ====================

    #region Addition Test Cases

    /// <summary>
    /// Addition test cases covering: positive, negative, mixed, zero, large numbers, overflow edge cases
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

        // Boundary: Very large numbers (potential overflow)
        yield return new TestCaseData(new int[] { int.MaxValue - 10, 5 }, int.MaxValue - 5).SetName("Addition_NearMaxValue_MaxValue_Minus10_Plus_5");
        yield return new TestCaseData(new int[] { int.MinValue + 10, -5 }, int.MinValue + 5).SetName("Addition_NearMinValue_MinValue_Plus10_Minus_5");
    }

    /// <summary>
    /// Addition double precision test cases including very small and very large numbers
    /// </summary>
    public static IEnumerable<TestCaseData> AdditionDoubleTestCases()
    {
        yield return new TestCaseData(new double[] { 2.5, 3.7 }, 6.2).SetName("Addition_Double_2.5_Plus_3.7");
        yield return new TestCaseData(new double[] { -2.5, -3.7 }, -6.2).SetName("Addition_Double_Negative");
        yield return new TestCaseData(new double[] { 0.1, 0.2 }, 0.3).SetName("Addition_Double_Precision_0.1_Plus_0.2");

        // Very small numbers
        yield return new TestCaseData(new double[] { 1e-10, 1e-10 }, 2e-10).SetName("Addition_Double_VerySmall_1e-10_Plus_1e-10");

        // Very large numbers
        yield return new TestCaseData(new double[] { 1e10, 1e10 }, 2e10).SetName("Addition_Double_VeryLarge_1e10_Plus_1e10");

        // Infinity cases
        yield return new TestCaseData(new double[] { double.PositiveInfinity, 5 }, double.PositiveInfinity).SetName("Addition_Double_Infinity_Plus_5");
        yield return new TestCaseData(new double[] { double.NegativeInfinity, 5 }, double.NegativeInfinity).SetName("Addition_Double_NegInfinity_Plus_5");
        yield return new TestCaseData(new double[] { double.PositiveInfinity, double.NegativeInfinity }, double.NaN).SetName("Addition_Double_Infinity_Plus_NegInfinity");
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
    /// Division double precision test cases including edge cases and special values
    /// </summary>
    public static IEnumerable<TestCaseData> DivisionDoubleTestCases()
    {
        yield return new TestCaseData(new double[] { 7.5, 2.5 }, 3.0).SetName("Division_Double_7.5_Divided_2.5");
        yield return new TestCaseData(new double[] { -7.5, 2.5 }, -3.0).SetName("Division_Double_Negative_Neg7.5_Divided_2.5");
        yield return new TestCaseData(new double[] { 1.0, 2.0 }, 0.5).SetName("Division_Double_1.0_Divided_2.0");

        // Very small divisor (precision test)
        yield return new TestCaseData(new double[] { 1.0, 1e-10 }, 1e10).SetName("Division_Double_VerySmallDivisor_1.0_Divided_1e-10");

        // Very large numbers
        yield return new TestCaseData(new double[] { 1e10, 1e5 }, 1e5).SetName("Division_Double_VeryLarge_1e10_Divided_1e5");

        // Infinity cases
        yield return new TestCaseData(new double[] { double.PositiveInfinity, 5 }, double.PositiveInfinity).SetName("Division_Double_Infinity_Divided_5");
        yield return new TestCaseData(new double[] { 5, double.PositiveInfinity }, 0.0).SetName("Division_Double_5_Divided_Infinity");
        yield return new TestCaseData(new double[] { 0, double.PositiveInfinity }, 0.0).SetName("Division_Double_0_Divided_Infinity");
    }

    #endregion

    // ==================== UNARY OPERATIONS (Sine, Cosine, Tangent) ====================

    #region Sine Test Cases

    /// <summary>
    /// Sine function test cases covering: special angles, large angles, small angles, negative angles, edge cases
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

        // Large angles (periodicity test: sin(x) = sin(x + 2π))
        yield return new TestCaseData(new double[] { 4 * Math.PI }, 0.0).SetName("Sin_Large_4Pi_sin(4pi)");
        yield return new TestCaseData(new double[] { 10 * Math.PI }, 0.0).SetName("Sin_VeryLarge_10Pi_sin(10pi)");

        // Very small angles (near zero, sin(x) ≈ x for small x)
        yield return new TestCaseData(new double[] { 0.001 }, Math.Sin(0.001)).SetName("Sin_VerySmall_sin(0.001)");
        yield return new TestCaseData(new double[] { 1e-10 }, Math.Sin(1e-10)).SetName("Sin_TinyAngle_sin(1e-10)");

        // Edge cases: Infinity and NaN
        yield return new TestCaseData(new double[] { double.PositiveInfinity }, double.NaN).SetName("Sin_Infinity_sin(+Inf)");
        yield return new TestCaseData(new double[] { double.NegativeInfinity }, double.NaN).SetName("Sin_NegInfinity_sin(-Inf)");
        yield return new TestCaseData(new double[] { double.NaN }, double.NaN).SetName("Sin_NaN_sin(NaN)");
    }

    #endregion

    #region Cosine Test Cases

    /// <summary>
    /// Cosine function test cases covering: special angles, large angles, small angles, negative angles, edge cases
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

        // Large angles (periodicity test: cos(x) = cos(x + 2π))
        yield return new TestCaseData(new double[] { 4 * Math.PI }, 1.0).SetName("Cos_Large_4Pi_cos(4pi)");
        yield return new TestCaseData(new double[] { 10 * Math.PI }, 1.0).SetName("Cos_VeryLarge_10Pi_cos(10pi)");

        // Very small angles (near zero, cos(x) ≈ 1 for small x)
        yield return new TestCaseData(new double[] { 0.001 }, Math.Cos(0.001)).SetName("Cos_VerySmall_cos(0.001)");
        yield return new TestCaseData(new double[] { 1e-10 }, Math.Cos(1e-10)).SetName("Cos_TinyAngle_cos(1e-10)");

        // Edge cases: Infinity and NaN
        yield return new TestCaseData(new double[] { double.PositiveInfinity }, double.NaN).SetName("Cos_Infinity_cos(+Inf)");
        yield return new TestCaseData(new double[] { double.NegativeInfinity }, double.NaN).SetName("Cos_NegInfinity_cos(-Inf)");
        yield return new TestCaseData(new double[] { double.NaN }, double.NaN).SetName("Cos_NaN_cos(NaN)");
    }

    #endregion

    #region Tangent Test Cases

    /// <summary>
    /// Tangent function test cases covering: special angles, large angles, small angles, undefined points, edge cases
    /// Note: Tan is undefined at pi/2, 3pi/2, etc. - these produce very large values in floating point
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

        // Large angles (periodicity test: tan(x) = tan(x + π))
        yield return new TestCaseData(new double[] { 4 * Math.PI }, 0.0).SetName("Tan_Large_4Pi_tan(4pi)");

        // Very small angles (near zero, tan(x) ≈ x for small x)
        yield return new TestCaseData(new double[] { 0.001 }, Math.Tan(0.001)).SetName("Tan_VerySmall_tan(0.001)");
        yield return new TestCaseData(new double[] { 1e-10 }, Math.Tan(1e-10)).SetName("Tan_TinyAngle_tan(1e-10)");

        // Edge cases: Infinity and NaN
        yield return new TestCaseData(new double[] { double.PositiveInfinity }, double.NaN).SetName("Tan_Infinity_tan(+Inf)");
        yield return new TestCaseData(new double[] { double.NegativeInfinity }, double.NaN).SetName("Tan_NegInfinity_tan(-Inf)");
        yield return new TestCaseData(new double[] { double.NaN }, double.NaN).SetName("Tan_NaN_tan(NaN)");

        // Note: Tests near undefined points (pi/2, 3pi/2) will result in very large positive/negative values
        // due to floating point precision - this is expected behavior for tangent function
    }

    #endregion

    // ==================== EDGE CASE & OVERFLOW TEST CASES ====================

    #region Integer Overflow Edge Cases

    /// <summary>
    /// Test multiplication with large integers that could cause overflow
    /// </summary>
    public static IEnumerable<TestCaseData> MultiplicationOverflowTestCases()
    {
        // Near maximum value boundaries
        yield return new TestCaseData(new int[] { int.MaxValue - 1, 1 }, int.MaxValue - 1).SetName("Mul_Overflow_MaxValue_Minus1_Times_1");
        yield return new TestCaseData(new int[] { int.MinValue + 1, 1 }, int.MinValue + 1).SetName("Mul_Overflow_MinValue_Plus1_Times_1");

        // Large number multiplication that would overflow
        yield return new TestCaseData(new int[] { 100000, 100000 }, 10000000000).SetName("Mul_Overflow_100000_Times_100000");
    }

    #endregion

    #region Floating Point Edge Cases

    /// <summary>
    /// Test floating point operations with very small, very large, and special values (NaN, Infinity)
    /// </summary>
    public static IEnumerable<TestCaseData> FloatingPointEdgeCaseTestCases()
    {
        // Extremely small numbers
        yield return new TestCaseData(new double[] { double.Epsilon, 1.0 }, double.Epsilon).SetName("FloatEdge_Epsilon_Plus_1");
        yield return new TestCaseData(new double[] { 1e-300, 1e-300 }, 2e-300).SetName("FloatEdge_1e-300_Plus_1e-300");

        // Extremely large numbers
        yield return new TestCaseData(new double[] { double.MaxValue / 2, 1.0 }, double.MaxValue / 2).SetName("FloatEdge_MaxValue_Div2_Plus_1");

        // Subnormal numbers (near zero)
        yield return new TestCaseData(new double[] { 5e-324, 5e-324 }, double.Epsilon).SetName("FloatEdge_Subnormal_Plus_Subnormal");

        // Negative zero
        yield return new TestCaseData(new double[] { -0.0, 0.0 }, 0.0).SetName("FloatEdge_NegZero_Plus_PosZero");
    }

    /// <summary>
    /// Test double precision arithmetic with mixed magnitude values
    /// </summary>
    public static IEnumerable<TestCaseData> MixedMagnitudeTestCases()
    {
        // Adding very large and very small numbers (precision loss)
        yield return new TestCaseData(new double[] { 1e20, 1e-20 }, 1e20).SetName("FloatEdge_LargeAndSmall_1e20_Plus_1e-20");

        // Multiplication with very small numbers
        yield return new TestCaseData(new double[] { 1e-100, 1e-100 }, 1e-200).SetName("FloatEdge_VerySmallMul_1e-100_Times_1e-100");

        // Division with very small denominator
        yield return new TestCaseData(new double[] { 1.0, 1e-100 }, 1e100).SetName("FloatEdge_SmallDenominator_1_Divided_1e-100");
    }

    #endregion

    #region Subtraction Edge Cases

    /// <summary>
    /// Subtraction test cases with edge conditions
    /// </summary>
    public static IEnumerable<TestCaseData> SubtractionEdgeCaseTestCases()
    {
        // Large positive minus large positive (could underflow to negative)
        yield return new TestCaseData(new int[] { 1000, 2000 }, -1000).SetName("Sub_Edge_1000_Minus_2000");

        // Negative minus negative (can become positive)
        yield return new TestCaseData(new int[] { -1000, -2000 }, 1000).SetName("Sub_Edge_Neg1000_Minus_Neg2000");

        // Very small differences
        yield return new TestCaseData(new double[] { 1.0000001, 1.0 }, 0.0000001).SetName("Sub_Edge_Double_VerySmallDifference");
    }

    #endregion

    #region Trigonometric Boundary Cases

    /// <summary>
    /// Test trigonometric functions at boundaries and special values
    /// </summary>
    public static IEnumerable<TestCaseData> TrigonometricBoundaryTestCases()
    {
        // Values very close to undefined points for tangent
        double almostPiHalf = Math.PI / 2 - 0.0001;
        yield return new TestCaseData(new double[] { almostPiHalf }, Math.Tan(almostPiHalf)).SetName("Trig_TanNearUndefined_AlmostPiHalf");

        // Values at exact multiples of 2π (should cycle back to original)
        yield return new TestCaseData(new double[] { 100 * Math.PI }, Math.Sin(100 * Math.PI)).SetName("Trig_SinLargeMultiple_100Pi");
        yield return new TestCaseData(new double[] { 100 * Math.PI }, Math.Cos(100 * Math.PI)).SetName("Trig_CosLargeMultiple_100Pi");

        // Negative very large angles
        yield return new TestCaseData(new double[] { -1000 * Math.PI }, Math.Sin(-1000 * Math.PI)).SetName("Trig_SinNegLargeAngle_Neg1000Pi");
    }

    #endregion
}
