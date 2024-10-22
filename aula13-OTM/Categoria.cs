namespace aula13_OTM {
    public class Categoria {
        public int CategoriaId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public List<Produtos> Produtos { get; set; } = new List<Produtos>();
    }
}