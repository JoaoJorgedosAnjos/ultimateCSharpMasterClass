using ObjectInitializers.Models;

var person = new Person("John")
{
    YearOfBirth = 1981
};

Console.WriteLine(person.Name);
Console.WriteLine(person.YearOfBirth);