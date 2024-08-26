using Shape;

namespace ShapeUnitTests;

[TestFixture]
public class TriangleTests
{
	/// <summary>
	/// Экспоненциальная запись нуля.
	/// </summary>
	private const double Epsilon = 1e-5;
	
	[TestCase(0, 4, 5)]
	[TestCase(3, 4, -5)]
	[TestCase(1, 2, 10)]
	public void Constructor_InvalidSides_ThrowsArgumentException(double sideA, double sideB, double sideC)
	{
		Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
	}
	
	[Test]
	public void Triangle_CorrectSidesValues_GivesCorrectAreaValue()
	{
		var triangle = new Triangle(3, 4, 5);
		var area = triangle.CalculateArea();
		Assert.That(area, Is.EqualTo(6).Within(Epsilon));
	}
	
	[TestCase(3, 4, 5)]
	[TestCase(5, 4, 3)]
	[TestCase(6, 5, 6)]
	public void IsRightAngled_TriangleIsRight_GivesTrue(double sideA, double sideB, double sideC)
	{
		var triangle = new Triangle(sideA, sideB, sideC);
		Assert.IsTrue(triangle.IsRightAngled());
	}

	[TestCase(3, 5, 3)]
	[TestCase(5, 5, 7)]
	[TestCase(4, 5, 7)]
	public void IsRightAngled_TriangleIsNotRight_GivesFalse(double sideA, double sideB, double sideC)
	{
		var triangle = new Triangle(sideA, sideB, sideC);
		Assert.IsFalse(triangle.IsRightAngled());
	}
}