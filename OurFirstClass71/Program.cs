using OurFirstClass.Classes;

var rectangle = new Rectangle(4, 8);
var calculator = new ShapesMeasurementsCalculator();
Console.WriteLine("Width is " + rectangle.Width);
Console.WriteLine("Height is " + rectangle.GetHeight);

Console.WriteLine(calculator.CalculateRectanglePerimeter(rectangle));
Console.WriteLine(calculator.CalculateRectangleArea(rectangle));

Console.WriteLine();

var calculator2 = new ShapesMeasurementsCalculator();
var rectangle2 = new Rectangle(5,10);
Console.WriteLine("Width is " + rectangle2.Width);
Console.WriteLine("Height is " + rectangle2.GetHeight);

Console.WriteLine(calculator2.CalculateRectanglePerimeter(rectangle2));
Console.WriteLine(calculator2.CalculateRectangleArea(rectangle2));


Console.Read();