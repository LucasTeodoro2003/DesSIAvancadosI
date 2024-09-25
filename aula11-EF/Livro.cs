namespace aula11_EF.Models
{
    public class Livro
    {
        public int Id { get; set; }

        private string nome = "";
        private decimal preco;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public decimal Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public Livro(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Preço: {Preco}";
        }
    }
}
