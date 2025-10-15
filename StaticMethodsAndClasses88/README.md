## Métodos e Classes Estáticas em C#

Métodos estáticos são funções que pertencem à classe, não a um objeto específico. Você chama um método estático usando o nome da classe, sem precisar criar uma instância. Eles são úteis para operações utilitárias, cálculos ou funções que não dependem de dados de um objeto.


```csharp
public class MathUtils {
    public static int Somar(int a, int b) => a + b;
}
// Uso: MathUtils.Somar(2, 3);
```
Classes estáticas são declaradas com a palavra-chave static e só podem conter membros estáticos. Elas não podem ser instanciadas (não usam new) e não podem ser herdadas. São ideais para agrupar métodos utilitários ou funções globais que não dependem de estado de objeto.


```csharp
public static class Conversor {
    public static double CelsiusParaFahrenheit(double c) => (c * 9 / 5) + 32;
}
// Uso: Conversor.CelsiusParaFahrenheit(20);
```
Características principais

    Métodos estáticos só acessam outros membros estáticos da classe.

    Classes estáticas não podem ser instanciadas nem herdadas.

    Usadas para organizar funções que não dependem de dados de instância.

    Exemplos do .NET: Math.Sqrt(), Console.WriteLine().




### 1. Métodos estáticos pertencem à classe, não a uma instância
- Quando você declara um método como `static`, ele **pertence à classe inteira** (por exemplo, `Math.Sqrt(9)`) e não a um objeto individual daquela classe.
- Você acessa esses métodos usando o nome da classe, **sem criar um objeto**.

### 2. Métodos estáticos não podem acessar dados de instância
- Um método estático **não pode usar variáveis de instância** (por exemplo, campos e propriedades não estáticos), porque ele não está ligado a nenhum objeto específico.
- Ele só pode usar dados que também são estáticos ou o que for passado como argumento.

**Exemplo prático:**
```csharp
public class Calculadora
{
    public static int Somar(int a, int b) => a + b; // Pode usar

    public int Numero;
    public int MultiplicarPorNumero(int valor) => valor * Numero; // Só funciona em métodos não estáticos
}

// Uso do método estático:
int resultado = Calculadora.Somar(2, 3); // Não precisa criar um objeto
```
Se restou alguma dúvida ou se quiser ver exemplos com métodos de instância vs estáticos, me avise!


