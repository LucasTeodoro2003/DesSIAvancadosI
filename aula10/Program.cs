using System;
using System.Collections.Generic;
using System.Linq;

// O metodo e um metodo de extensao da LINQ() (Language Integrated Query)
public class Program
{
    public static void Main()
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.Write("Os Numeros sao: ");
        numeros.ForEach(n => Console.Write($"{n}, "));

        // Usando uma expressao lambda para filtrar os numeros pares
        List<int> numerosPares = numeros.Where(n => n % 2 == 0).ToList();


        Console.WriteLine("\nNumeros Pares: ");
        numerosPares.ForEach(n => Console.Write($"{n}, "));

        List<string> frutas = new List<string> { "Maça", "Banana", "Manga", "Abacaxi", "Morango", "Melancia" };

        //Ordenando a lista de frutas por ordem alfabetica
        List<string> frutasOrdenadas = frutas.OrderBy(f => f).ToList();
        List<string> frutasComM = frutasOrdenadas.Where(f => f.StartsWith("M")).ToList();
        Console.WriteLine("\nFrutas Ordenados que começam com 'M': ");
        frutasComM.ForEach(f => Console.WriteLine(f));


        //Atividade 3
        List<Pessoa> pessoas = new List<Pessoa>{
            new Pessoa("Rafael", 33), new Pessoa("Cecilia", 1), new Pessoa("Maria", 22), new Pessoa("Daniel", 55), new Pessoa("Roberta", 28)
        };

        List<Pessoa> pessoasFiltradas = pessoas.Where(p => p.Idade > 25).OrderBy(p => p.Nome).ToList();

        Console.WriteLine("\n Pessoas com idade maior que 25, ordenadas por nome: \n");
        pessoasFiltradas.ForEach(p => Console.WriteLine($"Nome: {p.Nome}, Idade: {p.Idade}"));
    }
}