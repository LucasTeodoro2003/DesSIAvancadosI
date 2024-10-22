using Microsoft.EntityFrameworkCore;
using System.Linq;

class Program{
    static void Main(){
        using (var context = new AppDbContext()){
            context.Database.EnsureCreated();

            var novaPessoa = new Pessoa{Nome = "Lucas", Idade = 21};

            context.Pessoas.Add(novaPessoa);
            context.SaveChanges();

            var pessoas = context.Pessoas.ToList();
            foreach(var pessoa in pessoas){
                Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}");
            }
        }
    }
}