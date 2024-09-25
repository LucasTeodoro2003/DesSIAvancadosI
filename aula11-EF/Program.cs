using System.Linq;
using aula11_EF.Models;

public class Program{
    public static void Main(){
        using(var db = new AppDbContext()){
            db.Database.EnsureCreated();


            Cliente cliente1 = new Cliente("Lucas", 21);
            Cliente cliente2 = new Cliente("Tifany", 22);
            db.Cliente.Add(cliente1);
            db.Cliente.Add(cliente2);
            db.SaveChanges();

            Livro livro1 = new Livro("C# Para Iniciantes", 45.00M);
            Livro livro2 = new Livro("Java: Como Programar", 120.00M);
            db.Livro.AddRange(livro1, livro2);
            Console.WriteLine($"Livros adicionados: {livro1}, {livro2}");
            db.SaveChanges();

            Venda venda1 = new Venda(cliente1);
            venda1.AdicionarLivro(livro1);
            venda1.AdicionarLivro(livro2);
            db.Vendas.Add(venda1);
            db.SaveChanges();
            

            Console.WriteLine(venda1);
        }
    }
}