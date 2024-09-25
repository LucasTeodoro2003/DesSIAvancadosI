namespace aula11_EF.Models
{
    //Id
    //Cliente
    //List<Livros> livros

    public class Venda
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }

        public List<Livro> Livros { get; set; }

        //Construtor sem parametros necessario para o Entity Framework
        public Venda()
        {
            Cliente = new Cliente("", 0);
            Livros = new List<Livro>();
        }

        public Venda(Cliente cliente)
        {
            Cliente = cliente;
            Livros = new List<Livro>();
        }

        public void AdicionarLivro(Livro livro)
        {
            Livros.Add(livro);
        }

        public decimal CalculaTotal()
        {
            return Livros.Sum(l => l.Preco);
        }

        public void ListarLivrosMaisCaros(decimal x)
        {
            var livrosMaisCaros = Livros.Where(l => l.Preco > x).OrderBy(l => l.Nome).ToList();
            if (livrosMaisCaros.Count > 0)
            {
                Console.WriteLine($"Livros com o preco maior que {x}");
                livrosMaisCaros.ForEach(l => Console.Write($"Nome {l.Nome}, Preço: {l.Preco} \n"));
            }
            else
            {
                Console.WriteLine($"Não existem Livros com o preço maior que {x}");
            }
        }


        public void LivrosOrdenados()
        {
            var livrosOrdenados = Livros.OrderBy(l => l.Nome).ToList();
            livrosOrdenados.ForEach(l => Console.Write($"Nome: {l.Nome}, Preço: {l.Preco}"));
        }

        public override string ToString()
        {
            string livrosStr = string.Join(", ", Livros.Select(l => l.Nome));
            return $"Cliente: {Cliente.Nome}, Livro(s): [{livrosStr}], Total: {CalculaTotal()}";
        }
    }
}