using NUnit.Framework;
using Models.Vectors;
using Calculator.Tests.Fixtures;

namespace Calculator.Tests.Unit
{
    [TestFixture]
    public class Vector2DUnitTest
    {
        [TestCaseSource(typeof(VectorTestData),
            nameof(VectorTestData.Vector2AdditionTestCases))]
        public void Operator_Add_Works(Vector2D[] operands, Vector2D expected)
        {
            Vector2D result = operands[0] + operands[1];

            Assert.That(result.X, Is.EqualTo(expected.X).Within(0.0001));
            Assert.That(result.Y, Is.EqualTo(expected.Y).Within(0.0001));
        }

        [TestCaseSource(typeof(VectorTestData),
            nameof(VectorTestData.Vector2SubtractionTestCases))]
        public void Operator_Subtract_Works(Vector2D[] operands, Vector2D expected)
        {
            Vector2D result = operands[0] - operands[1];

            Assert.That(result.X, Is.EqualTo(expected.X).Within(0.0001));
            Assert.That(result.Y, Is.EqualTo(expected.Y).Within(0.0001));
        }

        [TestCaseSource(typeof(VectorTestData),
            nameof(VectorTestData.Vector2ScalarMultiplicationTestCases))]
        public void Operator_ScalarMultiply_Works(Vector2D vector, double scalar, Vector2D expected)
        {
            Vector2D result = vector * scalar;

            Assert.That(result.X, Is.EqualTo(expected.X).Within(0.0001));
            Assert.That(result.Y, Is.EqualTo(expected.Y).Within(0.0001));
        }

        [Test]
        public void Magnitude_ReturnsCorrectValue()
        {
            Vector2D vector = new Vector2D(3, 4);
            double magnitude = vector.Magnitude();

            Assert.That(magnitude, Is.EqualTo(5).Within(0.0001));
        }

        [Test]
        public void Normalize_ReturnsUnitVector()
        {
            Vector2D vector = new Vector2D(0, 5);
            Vector2D normalized = (Vector2D)vector.Normalize();

            Assert.That(normalized.X, Is.EqualTo(0).Within(0.0001));
            Assert.That(normalized.Y, Is.EqualTo(1).Within(0.0001));
        }

        [Test]
        public void Dot_Product_Works()
        {
            Vector2D a = new Vector2D(1, 2);
            Vector2D b = new Vector2D(3, 4);

            double dot = a.Dot(b);

            Assert.That(dot, Is.EqualTo(11));
        }
    }
}
