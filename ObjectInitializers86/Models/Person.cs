namespace ObjectInitializers.Models;

public class Person
{
    public string Name { get; set; }
    public int YearOfBirth { get; init; }

    public Person(string name)
    {
        Name = name;
    }

    public Person(string name, int yearOfBirth)
    {
        Name = name;
        YearOfBirth = YearOfBirth;
    }
}

// A palavra-chave init em C# define uma propriedade que só pode ser atribuída durante a inicialização do objeto, ou seja,
// no momento da criação usando inicializadores de objeto ou dentro do construtor.Depois que o objeto é criado, o valor da
// propriedade não pode mais ser alterado.
// Resumo sobre init
// Permite criar propriedades imutáveis que só podem ser definidas na construção do objeto.
// O valor pode ser atribuído usando inicializadores de objeto:
// csharp
// var person = new Person { Name = "Ana", YearOfBirth = 2000 };
//
// Após a inicialização, qualquer tentativa de alterar a propriedade gera erro de compilação.
//     É útil para garantir que certos dados do
//     objeto não mudem depois de criado, sem precisar de construtores complexos.
//     O init é uma alternativa ao set, mas restringe a atribuição ao momento da criação do objeto.