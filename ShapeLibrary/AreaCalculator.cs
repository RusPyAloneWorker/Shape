namespace Shape;

/// <summary>
/// Калькулятор площади.
/// </summary>
public static class AreaCalculator
{
	/// <summary>
	/// Вычислить площадь фигуры.
	/// </summary>
	/// <param name="shape">Фигура.</param>
	/// <returns>Площадь.</returns>
	public static double CalculateArea(IShape shape)
	{
		return shape.CalculateArea();
	}
}