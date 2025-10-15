using System.ComponentModel;

namespace StaticMethodsAndClasses.Models;

public class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;

}

public class NoStaticClass
{
    public int Cal() => 2 + 2;
    public static string DescribeGenerally() => $"A plane figure with four...";
}