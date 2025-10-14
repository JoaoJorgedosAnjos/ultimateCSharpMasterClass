using System.Data;

namespace OurFirstClass.Classes;

public class Rectangle
{
    public int Width;
    public int Height;

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }
}

class ShapesMeasurementsCalculator
{
    public int CalculateRectanglePerimeter(Rectangle rectangle)
    {
        return 2 * rectangle.Width + 2 * rectangle.Height;
    }

    public int CalculateRectangleArea(Rectangle rectangle)
    {
        return rectangle.Width * rectangle.Height;
    }
}