using Shape;

namespace ShapeLibrary;

public class Program
{
	public static void Main()
	{
		IShape circleShape = new Circle(5);
		IShape triangleShape = new Triangle(3, 4, 5);

		Console.WriteLine(circleShape.CalculateArea());
		Console.WriteLine(triangleShape.CalculateArea());
		Console.WriteLine(((Triangle)triangleShape).IsRightAngled());
	}
}