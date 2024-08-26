namespace Shape;

/// <summary>
/// Треугольник.
/// </summary>
public class Triangle : IShape
{
	/// <summary>
	/// Первая сторона.
	/// </summary>
	public double SideA { get; private set; }
	
	/// <summary>
	/// Вторая сторона.
	/// </summary>
	public double SideB { get; private set; }
	
	/// <summary>
	/// Третья сторона.
	/// </summary>
	public double SideC { get; private set; }

	public Triangle(double sideA, double sideB, double sideC)
	{
		if (sideA <= 0 || sideB <= 0 || sideC <= 0)
		{
			throw new ArgumentException("All sides must be greater than zero.");
		}

		if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
		{
			throw new ArgumentException("The sum of any two sides must be greater than the third side.");
		}
		
		SideA = sideA;
		SideB = sideB;
		SideC = sideC;
	}
	
	/// <summary>
	/// Вычисляет площадь треугольника.
	/// </summary>
	/// <returns>Плошадь.</returns>
	public double CalculateArea()
	{
		var semiPerimeter = (SideA + SideB + SideC) / 2;
		return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
	}

	/// <summary>
	/// Вычисляет, является ли треугольник прямоугольным.
	/// </summary>
	/// <returns>True - прямоугольный, False -  непрямогульный.</returns>
	public bool IsRightAngled()
	{
		var sides = new []{ SideA, SideB, SideC };
		Array.Sort(sides);
		return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-10;
	}
}