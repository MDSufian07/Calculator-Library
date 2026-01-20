using System.Collections;
using Models.Vectors;
using NUnit.Framework;

namespace Calculator.Tests.Fixtures
{
    public class VectorTestData
    {
        public static IEnumerable Vector3AdditionTestCases
        {
            get
            {
                yield return new TestCaseData(
                    new[] { new Vector3D(1, 2, 3), new Vector3D(4, 5, 6) },
                    new Vector3D(5, 7, 9)
                ).SetName("Add_PositiveVectors_ReturnsSum");

                yield return new TestCaseData(
                    new[] { new Vector3D(-1, -2, -3), new Vector3D(-4, -5, -6) },
                    new Vector3D(-5, -7, -9)
                ).SetName("Add_NegativeVectors_ReturnsSum");

                yield return new TestCaseData(
                    new[] { new Vector3D(1, -2, 3), new Vector3D(-1, 2, -3) },
                    new Vector3D(0, 0, 0)
                ).SetName("Add_MixedVectors_ReturnsZero");
            }
        }

        public static IEnumerable Vector3SubtractionTestCases
        {
            get
            {
                yield return new TestCaseData(
                    new[] { new Vector3D(5, 7, 9), new Vector3D(4, 5, 6) },
                    new Vector3D(1, 2, 3)
                ).SetName("Subtract_PositiveVectors_ReturnsDifference");

                yield return new TestCaseData(
                    new[] { new Vector3D(-5, -7, -9), new Vector3D(-4, -5, -6) },
                    new Vector3D(-1, -2, -3)
                ).SetName("Subtract_NegativeVectors_ReturnsDifference");

                yield return new TestCaseData(
                    new[] { new Vector3D(1, 2, 3), new Vector3D(1, 2, 3) },
                    new Vector3D(0, 0, 0)
                ).SetName("Subtract_SameVectors_ReturnsZero");
            }
        }

        public static IEnumerable Vector3ScalarMultiplicationTestCases
        {
            get
            {
                yield return new TestCaseData(
                    new Vector3D(1, 2, 3),
                    2.0,
                    new Vector3D(2, 4, 6)
                ).SetName("Multiply_PositiveScalar_ReturnsScaledVector");

                yield return new TestCaseData(
                    new Vector3D(1, 2, 3),
                    -2.0,
                    new Vector3D(-2, -4, -6)
                ).SetName("Multiply_NegativeScalar_ReturnsInvertedScaledVector");

                yield return new TestCaseData(
                    new Vector3D(1, 2, 3),
                    0.0,
                    new Vector3D(0, 0, 0)
                ).SetName("Multiply_ZeroScalar_ReturnsZeroVector");
            }
        }

        public static IEnumerable Vector2AdditionTestCases
        {
            get
            {
                yield return new TestCaseData(
                    new[] { new Vector2D(1, 2), new Vector2D(3, 4) },
                    new Vector2D(4, 6)
                ).SetName("Add_PositiveVectors_ReturnsSum");
            }
        }

        public static IEnumerable Vector2SubtractionTestCases
        {
            get
            {
                yield return new TestCaseData(
                    new[] { new Vector2D(3, 4), new Vector2D(1, 2) },
                    new Vector2D(2, 2)
                ).SetName("Subtract_PositiveVectors_ReturnsDifference");
            }
        }

        public static IEnumerable Vector2ScalarMultiplicationTestCases
        {
            get
            {
                yield return new TestCaseData(
                    new Vector2D(1, 2),
                    2.0,
                    new Vector2D(2, 4)
                ).SetName("Multiply_PositiveScalar_ReturnsScaledVector");
            }
        }
    }
}
