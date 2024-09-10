public class Program
{
    public static void Main()
    {

        //Criando Clientes
        Cliente cliente1 = new Cliente(1, "João");
        Cliente cliente2 = new Cliente(2, "Jorge");
        Cliente cliente3 = new Cliente(3, "Thiago");
        Cliente cliente4 = new Cliente(4, "Ruan");
        Cliente cliente5 = new Cliente(5, "Juan");
        Cliente cliente6 = new Cliente(6, "Bia");
        Cliente cliente7 = new Cliente(7, "Guilherme");
        Cliente cliente8 = new Cliente(8, "Alemão");


        ///Criando Produtos
        Produto produto1 = new Produto(1, "Notebook", 3500.00M);
        Produto produto2 = new Produto(2, "Notebook Positivo", 10.00M);
        Produto produto3 = new Produto(3, "Pendrive Kill", 4000.00M);
        Produto produto4 = new Produto(4, "Celular Positivo", 8.00M);
        Produto produto5 = new Produto(5, "Fone de Ouvido", 15.00M);
        Produto produto6 = new Produto(6, "Tablet", 1200.00M);


        // Criando compra para cliente 1
        Compra compra1 = new Compra(cliente1);
        compra1.AdcionarProduto(produto1);
        compra1.AdcionarProduto(produto3);
        compra1.AdcionarProduto(produto5);
        compra1.AdcionarProduto(produto6);

        // Criando compra para cliente 2
        Compra compra2 = new Compra(cliente2);
        compra2.AdcionarProduto(produto2);
        compra2.AdcionarProduto(produto4);
        compra2.AdcionarProduto(produto4);
        compra2.AdcionarProduto(produto3);


        // Exibir as compras

        Console.WriteLine(compra1);
        Console.WriteLine(compra2);

    }
}