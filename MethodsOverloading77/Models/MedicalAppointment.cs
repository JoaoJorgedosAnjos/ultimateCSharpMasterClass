namespace MethodsOverloading77.Model;

public class MedicalAppointment
{
    private string _patienteName;
    private DateTime _date;

    public MedicalAppointment(string patienteName, DateTime date)
    {
        _patienteName = patienteName;
        _date = date;
    }

    public DateTime GetDate() => _date;

    // Optional Parameters
    // public MedicalAppointment(string patienteName) :
    //     this(patienteName, 7)
    // {
    // }

    public MedicalAppointment(string patienteName, int dayFromNow = 7)
    {
        _patienteName = patienteName;
        _date = DateTime.Now.AddDays(dayFromNow);
    }

    /*
     O que aconteceu nesse trecho é o uso de sobrecarga de construtores com chamada encadeada usando this. Veja o funcionamento:

     O construtor MedicalAppointment(string patienteName) chama outro construtor da mesma classe usando this(patienteName, 7). Isso significa que, ao criar um objeto passando apenas o nome do paciente, o valor padrão para dayFromNow será 7.

     O construtor MedicalAppointment(string patienteName, int dayFromNow) inicializa os campos, definindo _patienteName e calculando _date como a data atual mais o número de dias informado.
      */

    public void Reschedule(DateTime date)
    {
        _date = date;
        var printer = new MedicalAppointmentPrinter();
        printer.Print(this);
    }
    // this representa o próprio objeto da classe.
    //     É usado para passar a instância atual como argumento para outros métodos ou classes.
    //     Permite acessar membros e métodos do objeto de forma clara e direta.
    //     Esse conceito é essencial em programação orientada a objetos para manipular e compartilhar o estado do objeto
    //     de maneira segura e organizada

    public void Reschedule(int month, int day)
    {
        _date = new DateTime(_date.Year, month, day);
    }
}

class MedicalAppointmentPrinter
{
    public void Print(MedicalAppointment medicalAppointment)
    {
        Console.WriteLine("Appointment will take place on " + medicalAppointment.GetDate());
    }
}

/*
 * Regras para Method Overloading em C#

   Você pode usar métodos sobrecarregados (method overloading) em C# quando quiser ter vários métodos com o mesmo nome, desde que haja diferença nos parâmetros. As principais regras são:

       Nomes iguais, assinaturas diferentes: Os métodos devem ter o mesmo nome, mas os parâmetros precisam ser diferentes em quantidade, tipo ou ordem.

   ​

   Não importa o tipo de retorno: Apenas mudar o tipo de retorno não é suficiente para sobrecarregar; a diferença deve estar nos parâmetros.

   ​

   Exemplos de sobrecarga:

       Mudando o número de parâmetros (void Reschedule(DateTime date), void Reschedule(int month, int day))

       Mudando o tipo dos parâmetros (void Print(int x), void Print(string x))

       Mudando a ordem dos parâmetros (void Method(int x, string y) / void Method(string y, int x))

   Utilidade: Permite usar o mesmo nome de método para comportamentos semelhantes, melhorando a legibilidade e manutenção do código.

   Sobrecarga de Construtor em C#

   A sobrecarga de construtor permite criar múltiplos construtores em uma mesma classe, cada um com diferentes assinaturas de parâmetros. As principais regras são:

   ​

       Nome igual ao da classe: Todo construtor deve ter exatamente o mesmo nome da classe.

       Assinaturas diferentes: Os construtores devem diferir em quantidade, tipos ou ordem dos parâmetros.

       Objetivo: Permite instanciar objetos de maneiras diferentes conforme os dados disponíveis ou o contexto de uso.

       Construtor padrão: Se nenhum construtor for definido, o C# cria um construtor padrão (sem parâmetros).

   */