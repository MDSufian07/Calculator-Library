namespace Models.Vectors;

using System;
using Core.Operations;

/// <summary>
/// Represents a 3D vector with common vector operations.
/// Reuses Calculator operations for arithmetic logic.
/// Implements IVector3 interface following LSP (Liskov Substitution Principle).
/// </summary>
public class Vector3D : IVector3
{
    public double X { get; }
    public double Y { get; }
    public double Z { get; }

    /// <summary>
    /// Initializes a new instance of Vector3D.
    /// </summary>
    /// <param name="x">X component</param>
    /// <param name="y">Y component</param>
    /// <param name="z">Z component</param>
    public Vector3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    /// <summary>
    /// Calculates the magnitude (length) of the vector.
    /// </summary>
    /// <returns>The magnitude value</returns>
    public double Magnitude()
    {
        return Math.Sqrt((X * X) + (Y * Y) + (Z * Z));
    }

    /// <summary>
    /// Calculates the Euclidean distance between two vectors.
    /// </summary>
    /// <param name="other">The other vector</param>
    /// <returns>The distance value</returns>
    public double Distance(IVector other)
    {
        if (other is not IVector3 vector3D)
            throw new ArgumentException("Can only calculate distance to another 3D vector", nameof(other));

        double dx = X - vector3D.X;
        double dy = Y - vector3D.Y;
        double dz = Z - vector3D.Z;
        return Math.Sqrt((dx * dx) + (dy * dy) + (dz * dz));
    }

    /// <summary>
    /// Returns a normalized vector (unit length) in the same direction.
    /// </summary>
    /// <returns>A unit vector in the same direction</returns>
    public IVector Normalize()
    {
        double magnitude = this.Magnitude();
        if (magnitude == 0)
            throw new InvalidOperationException("Cannot normalize a zero vector");

        return new Vector3D(X / magnitude, Y / magnitude, Z / magnitude);
    }

    /// <summary>
    /// Calculates the dot product with another 3D vector.
    /// </summary>
    /// <param name="other">The other vector</param>
    /// <returns>The dot product value</returns>
    public double Dot(IVector3 other)
    {
        if (other == null)
            throw new ArgumentNullException(nameof(other));

        return (X * other.X) + (Y * other.Y) + (Z * other.Z);
    }

    /// <summary>
    /// Calculates the cross product with another 3D vector.
    /// Returns a new vector perpendicular to both input vectors.
    /// </summary>
    /// <param name="other">The other vector</param>
    /// <returns>The cross product vector</returns>
    public IVector3 Cross(IVector3 other)
    {
        if (other == null)
            throw new ArgumentNullException(nameof(other));

        double x = (Y * other.Z) - (Z * other.Y);
        double y = (Z * other.X) - (X * other.Z);
        double z = (X * other.Y) - (Y * other.X);

        return new Vector3D(x, y, z);
    }

    /// <summary>
    /// Vector addition using Calculator operations.
    /// </summary>
    /// <param name="a">First vector</param>
    /// <param name="b">Second vector</param>
    /// <returns>Sum of vectors</returns>
    public static Vector3D operator +(Vector3D a, Vector3D b)
    {
        if (a == null || b == null)
            throw new ArgumentNullException(a == null ? nameof(a) : nameof(b));

        var addition = new AdditionOperation();

        double newX = addition.Execute(new[] { a.X, b.X });
        double newY = addition.Execute(new[] { a.Y, b.Y });
        double newZ = addition.Execute(new[] { a.Z, b.Z });
        
        return new Vector3D(newX, newY, newZ);
    }

    /// <summary>
    /// Vector subtraction using Calculator operations.
    /// </summary>
    /// <param name="a">First vector</param>
    /// <param name="b">Second vector</param>
    /// <returns>Difference of vectors</returns>
    public static Vector3D operator -(Vector3D a, Vector3D b)
    {
        if (a == null || b == null)
            throw new ArgumentNullException(a == null ? nameof(a) : nameof(b));

        var subtraction = new SubtractionOperation();

        double newX = subtraction.Execute(new[] { a.X, b.X });
        double newY = subtraction.Execute(new[] { a.Y, b.Y });
        double newZ = subtraction.Execute(new[] { a.Z, b.Z });
        
        return new Vector3D(newX, newY, newZ);
    }

    /// <summary>
    /// Scalar multiplication using Calculator operations.
    /// </summary>
    /// <param name="v">Vector to multiply</param>
    /// <param name="scalar">Scalar value</param>
    /// <returns>Scaled vector</returns>
    public static Vector3D operator *(Vector3D v, double scalar)
    {
        if (v == null)
            throw new ArgumentNullException(nameof(v));

        var multiplication = new MultiplicationOperation();

        double newX = multiplication.Execute(new[] { v.X, scalar });
        double newY = multiplication.Execute(new[] { v.Y, scalar });
        double newZ = multiplication.Execute(new[] { v.Z, scalar });
        
        return new Vector3D(newX, newY, newZ);
    }

    /// <summary>
    /// Scalar multiplication operator (reversed operands).
    /// </summary>
    /// <param name="scalar">Scalar value</param>
    /// <param name="v">Vector to multiply</param>
    /// <returns>Scaled vector</returns>
    public static Vector3D operator *(double scalar, Vector3D v)
    {
        return v * scalar;
    }

    /// <summary>
    /// Determines whether the specified object is equal to the current vector.
    /// </summary>
    /// <param name="obj">The object to compare</param>
    /// <returns>True if equal; otherwise, false</returns>
    public override bool Equals(object? obj)
    {
        return obj is Vector3D vector && 
               X == vector.X && 
               Y == vector.Y && 
               Z == vector.Z;
    }

    /// <summary>
    /// Serves as the default hash function.
    /// </summary>
    /// <returns>A hash code for the current object</returns>
    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y, Z);
    }

    /// <summary>
    /// Returns the string representation of the vector.
    /// </summary>
    /// <returns>String in format (X, Y, Z)</returns>
    public override string ToString()
    {
        return $"({X}, {Y}, {Z})";
    }
}