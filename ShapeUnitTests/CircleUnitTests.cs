using Shape;

namespace ShapeUnitTests;

[TestFixture]
public class ShapeTests
{
	/// <summary>
	/// Экспоненциальная запись нуля.
	/// </summary>
	private const double Epsilon = 1e-5;
	
	[TestCase(-1)]
	[TestCase(-5)]
	[TestCase(-999)]
	public void Constructor_InvalidRadius_ThrowsArgumentException(int radius)
	{
		Assert.Throws<ArgumentException>(() => new Circle(radius));
	}

	[Test]
	public void CalculateArea_CorrectRadius_GivesCorrectAreaValue()
	{
		var radius = 5;
		var circle = new Circle(radius);
		var area = circle.CalculateArea();
		
		Assert.That(area, Is.EqualTo(Math.PI * radius * radius).Within(Epsilon));
	}
}