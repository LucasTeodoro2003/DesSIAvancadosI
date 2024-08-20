using System;

public class Program{
    static List<Pessoa> pessoas = new List<Pessoa>();
    static void Main(string[] args){
        Console.WriteLine("Inserir Pessoa na Lista!");
        pessoas.Add(new Pessoa("Lucas", 21));
        foreach(Pessoa aux in pessoas){
            Console.WriteLine(aux.ToString());
        }
    }
}