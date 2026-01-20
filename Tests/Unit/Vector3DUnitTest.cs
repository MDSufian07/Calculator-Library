using NUnit.Framework;
using Models.Vectors;
using Calculator.Tests.Fixtures;

namespace Calculator.Tests.Unit
{
    [TestFixture]
    public class Vector3DUnitTest
    {
        [TestCaseSource(typeof(VectorTestData),
            nameof(VectorTestData.Vector3AdditionTestCases))]
        public void Operator_Add_Works(Vector3D[] operands, Vector3D expected)
        {
            Vector3D result = operands[0] + operands[1];

            Assert.That(result.X, Is.EqualTo(expected.X).Within(0.0001));
            Assert.That(result.Y, Is.EqualTo(expected.Y).Within(0.0001));
            Assert.That(result.Z, Is.EqualTo(expected.Z).Within(0.0001));
        }

        [TestCaseSource(typeof(VectorTestData),
            nameof(VectorTestData.Vector3SubtractionTestCases))]
        public void Operator_Subtract_Works(Vector3D[] operands, Vector3D expected)
        {
            Vector3D result = operands[0] - operands[1];

            Assert.That(result.X, Is.EqualTo(expected.X).Within(0.0001));
            Assert.That(result.Y, Is.EqualTo(expected.Y).Within(0.0001));
            Assert.That(result.Z, Is.EqualTo(expected.Z).Within(0.0001));
        }

        [TestCaseSource(typeof(VectorTestData),
            nameof(VectorTestData.Vector3ScalarMultiplicationTestCases))]
        public void Operator_ScalarMultiply_Works(Vector3D vector, double scalar, Vector3D expected)
        {
            Vector3D result = vector * scalar;

            Assert.That(result.X, Is.EqualTo(expected.X).Within(0.0001));
            Assert.That(result.Y, Is.EqualTo(expected.Y).Within(0.0001));
            Assert.That(result.Z, Is.EqualTo(expected.Z).Within(0.0001));
        }

        [Test]
        public void Magnitude_ReturnsCorrectValue()
        {
            Vector3D vector = new Vector3D(3, 4, 12);
            double magnitude = vector.Magnitude();

            Assert.That(magnitude, Is.EqualTo(13).Within(0.0001));
        }

        [Test]
        public void Normalize_ReturnsUnitVector()
        {
            Vector3D vector = new Vector3D(0, 0, 5);
            Vector3D normalized = (Vector3D)vector.Normalize();

            Assert.That(normalized.X, Is.EqualTo(0).Within(0.0001));
            Assert.That(normalized.Y, Is.EqualTo(0).Within(0.0001));
            Assert.That(normalized.Z, Is.EqualTo(1).Within(0.0001));
        }

        [Test]
        public void Dot_Product_Works()
        {
            Vector3D a = new Vector3D(1, 2, 3);
            Vector3D b = new Vector3D(4, 5, 6);

            double dot = a.Dot(b);

            Assert.That(dot, Is.EqualTo(32));
        }

        [Test]
        public void Cross_Product_Works()
        {
            Vector3D a = new Vector3D(1, 0, 0);
            Vector3D b = new Vector3D(0, 1, 0);

            Vector3D cross = (Vector3D)a.Cross(b);

            Assert.That(cross.X, Is.EqualTo(0));
            Assert.That(cross.Y, Is.EqualTo(0));
            Assert.That(cross.Z, Is.EqualTo(1));
        }
    }
}
