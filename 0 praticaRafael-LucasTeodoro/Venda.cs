using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class Venda
{
    public Cliente Cliente { get; set; }
    public List<Livro> Livros { get; set; }

    public Venda(Cliente cliente)
    {
        Cliente = cliente;
        Livros = new List<Livro>();
    }

    public void AdicionarLivro(Livro livro)
    {
        Livros.Add(livro);
    }

    public decimal CalcularValorTotalCompra()
    {
        return Livros.Sum(l => l.Preco);
    }


    public void ListarLivrosMaisCaros(decimal x)
    {
        List<Livro> livrosMaisCaros = Livros.Where(l => l.Preco > x).ToList();
        livrosMaisCaros.ForEach(l => Console.Write($"{l}, \n"));
    }

    public void ListarLivrosEmOrdemAlfabetica(){
        List<Livro> livrosOrdenados = Livros.OrderBy(l => l.Nome).ToList();
        livrosOrdenados.ForEach(l => Console.Write($"{l}, \n"));
    }


    public override string ToString()
    {
        string livrsStr = String.Join(",", Livros);
        return $"Nome do Cliente: {Cliente.Nome}, Livros: {livrsStr}, Valor Total: {CalcularValorTotalCompra()}\n";
    }

}