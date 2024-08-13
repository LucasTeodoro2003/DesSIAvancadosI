using System;

public class Proram
{
    public static void Main(string[] args)
    {
        // Cadastrar dados Pessoa
        Console.WriteLine("Cadastro de Pessoa! \n");
        Console.Write("Nome:");
        string nomePessoa = Console.ReadLine();
        Console.Write("Idade:");
        var idadePessoa = int.Parse(Console.ReadLine());

        Pessoa pessoa1 = new Pessoa(nomePessoa, idadePessoa);
        Console.WriteLine("Pessoa Cadastrada com sucesso! \n");

        Console.WriteLine(pessoa1.ToString());
    }
}