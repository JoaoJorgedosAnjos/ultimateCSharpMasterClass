namespace Exercises.Classes;

public static class NumberToDayOfWeekTranslator
{
    public static string Translate(int number)
    {
        var result = number switch
        {
            1 => "Monday",
            2 => "Tuesday",
            3 => "Wednesday",
            4 => "Thursday",
            5 => "Friday",
            6 => "Saturday",
            7 => "Sunday",
            _ => "Invalid day of the week"
        };
        return result;
    }
}

// A classe e o método podem ser estáticos porque **não precisam acessar nenhum estado de objeto** — eles apenas recebem o parâmetro `number` e retornam o nome do dia correspondente, sem utilizar ou modificar campos ou propriedades de instância.[3][4][7]
//
// ### Por que podem ser estáticos?
//
//     - **Classes utilitárias:** Quando uma classe só fornece funções que fazem cálculos ou traduções usando os dados recebidos (e não dependem de dados internos), é comum (e recomendado) torná-la estática.[4]
//     - **Não precisam ser instanciados:** Não há necessidade de criar um objeto para usar o método. Você pode chamar diretamente: `NumberToDayOfWeekTranslator.Translate(3)`.
// - **Métodos estáticos só usam parâmetros:** O método `Translate` só trabalha com o argumento `number`, sem acessar ou alterar nada do "objeto".
// - **Organização do código:** Isso deixa claro que o método não depende de estado interno; ele é uma função "pura", que sempre retorna o mesmo resultado para o mesmo argumento.
//
// ### Resumo
//
// - Classes e métodos podem ser estáticos quando **não dependem do estado da instância** e servem para processar, converter, ou retornar informações a partir dos parâmetros recebidos.
// - Ajuda a evitar erros, facilita o uso, e melhora a manutenção do código.[7][3][4]
