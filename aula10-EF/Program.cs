using aula10_EF.Models;

class Program
{
    public static void Main(string[] args){
        using (var context = new PessoaContext())
{
    //Criar o banco de dados se ele nao existir
    context.Database.EnsureCreated();

    //Adicionar nova pessoa ao banco
    var pessoa = new Pessoa
    {
        Nome = "Lucas",
        Idade = 33
    };

    context.Pessoas.Add(pessoa);
    context.SaveChanges();

    // Listar as pessoas Cadastradas

    var listarPessoas = context.Pessoas.ToList();
    foreach(var p in listarPessoas){
        Console.WriteLine($"Nome: {p.Nome}, Idade: {p.Idade}");
    }
        }
    }
}