using System;
public class Program
{

    public static void MediaNota(double nota)
    {
        if (nota < 60)
        {
            Console.WriteLine("Aluno reprovado com a nota: " + nota);
        }
        else
        {
            Console.WriteLine("Aluno aprovado com a nota: " + nota);
        }
    }

    public delegate void ExibirNumero(double num);

    public static void ExibirQuadrado(double numero)
    {
        Console.WriteLine($"O quadrado do numero {numero} é: {numero * numero}");
    }
    public static void ImprimeNumero(double numero)
    {
        Console.WriteLine($"O numero é: {numero}");
    }

    // public static void VerificaNota(double notaAluno)
    // {
    //     if (notaAluno > 60)
    //     {
    //         Console.WriteLine("Passou!");
    //     }
    //     else
    //     {
    //         Console.WriteLine("Bombou carai");
    //     }
    // }

    public static void Main(string[] args)
    {
        ExibirNumero meuDelegate = ImprimeNumero;

        meuDelegate(10);

        meuDelegate += ExibirQuadrado;
        meuDelegate(2);

        meuDelegate += delegate (double num)
        {
            Console.WriteLine($"O dobro do numero {num} é {num * 2}");
        };

        meuDelegate(3);


        // Console.WriteLine("Qual o nome do Aluno?");
        // string? nomeAluno = Console.ReadLine();
        // Console.WriteLine("Qual a nota do aluno?");
        // double notaAluno = double.Parse(Console.ReadLine());


        // Pessoa objPessoa = new Pessoa(nomeAluno, notaAluno);

        // VerificaNota(notaAluno);

        Pessoa objPessoa = new Pessoa("Lucas", 21);
        meuDelegate += MediaNota;
        meuDelegate(objPessoa.Nota);
    }
}