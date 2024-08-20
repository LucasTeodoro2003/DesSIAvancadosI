using System;

public Program{
    static List<Pessoa> pessoas = new List<Pessoa>();
    static void Main(string[] args){
        Console.WriteLine("Inserir Pessoa na Lista!");
        pessoas.add(new Pessoa("Lucas", 21));
        foreach(Pessoa aux in pessoas){
            Console.WriteLine(aux.ToString());
        }
    }
}