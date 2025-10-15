using System.Data;

namespace OurFirstClass.Classes;

public class Rectangle
{
    private const int NumberOfSides = 4;
    public int Width;
    private int _height;

    public Rectangle(int width, int height)
    {
        Width = GetLenghtOrDefault(width, nameof(Width));
        _height = GetLenghtOrDefault(height, nameof(_height));
    }

    public int GetHeight => _height;

    public void SetHeigth(int value)
    {
        if (value > 0)
        {
            _height = value;
        }
    }

    private int GetLenghtOrDefault(int lenght, string name)
    {
        const int defaultValueIfNonPositive = 1;
        if (lenght <= 0)
        {
            _height = defaultValueIfNonPositive;
        }

        return lenght;
    }
}

class ShapesMeasurementsCalculator
{
    //Expression-bodied methods
    public int CalculateRectanglePerimeter(Rectangle rectangle) => 2 * rectangle.Width + 2 * rectangle.GetHeight;

    // public int CalculateRectanglePerimeter(Rectangle rectangle)
    // {
    //     return 2 * rectangle.Width + 2 * rectangle.Height;
    // }
    //Expression-bodied methods
    public int CalculateRectangleArea(Rectangle rectangle) => rectangle.Width * rectangle.GetHeight;

    // public int CalculateRectangleArea(Rectangle rectangle)
    // {
    //     return rectangle.Width * rectangle.Height;
    // }
}

// No C#, GetHeight é uma propriedade do tipo "expressão de corpo"(expression - bodied property), e não um método, por isso
//     não é chamado com parênteses().Por que usar GetHeight e não GetHeight() ? GetHeight foi declarado assim:
//
// csharp
// public int GetHeight => _height;
//
// Isso define uma propriedade de somente leitura que retorna o valor de _height.
//     Propriedades são acessadas como campos, sem usar parênteses, ao contrário de métodos.
//     Se fosse um método, seria declarado assim:
//
// csharp
//
// public int GetHeight()
// {
//     return _height;
// }
//
// e aí você precisaria chamar com os parênteses, ou seja, GetHeight().Resumo
//
// Propriedades em C# são acessadas sem(), pois se comportam como campos calculados.
//     Métodos precisam ser chamados com().Usar propriedades para acessar valores privados é uma prática comum
//     em C#, oferecendo encapsulamento sem parecer um método explícito.No seu código, GetHeight é uma
//     propriedade, por isso você usa rectangle.GetHeight e não GetHeight().