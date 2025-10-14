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
    //Expression-bodied methods
    public int CalculateRectanglePerimeter(Rectangle rectangle) => 2 * rectangle.Width + 2 * rectangle.Height;
    
    // public int CalculateRectanglePerimeter(Rectangle rectangle)
    // {
    //     return 2 * rectangle.Width + 2 * rectangle.Height;
    // }
    //Expression-bodied methods
    public int CalculateRectangleArea(Rectangle rectangle) => rectangle.Width * rectangle.Height;
    
    // public int CalculateRectangleArea(Rectangle rectangle)
    // {
    //     return rectangle.Width * rectangle.Height;
    // }
}