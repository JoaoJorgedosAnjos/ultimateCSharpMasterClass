// See https://aka.ms/new-console-template for more information

using StaticMethodsAndClasses.Models;

Console.WriteLine($"1 + 2 is {Calculator.Add(1,2)}");

Console.WriteLine(NoStaticClass.DescribeGenerally());

// Using fields of a class in a static method doesn't make sense.
//
// This method will not be called on any object, but on the class as a whole, so it can't know the values 
//     of the fields of this object.