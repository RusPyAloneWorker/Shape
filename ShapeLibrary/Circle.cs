namespace Shape;

/// <summary>
/// Окружность.
/// </summary>
public class Circle: IShape
{
	/// <summary>
	/// Радиус.
	/// </summary>
	public double Radius { get; private set; }

	public Circle(double radius)
	{
		if (radius < 0)
		{
			throw new ArgumentException("Radius is lower than 0");
		}
		
		Radius = radius;
	}

	/// <summary>
	/// Вычисляет площадь окружности.
	/// </summary>
	/// <returns>Площадь.</returns>
	public double CalculateArea()
	{
		return Math.PI * Radius * Radius;
	}
}