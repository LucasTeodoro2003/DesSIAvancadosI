namespace aula13_OTM {
    public class Produtos {
        public int ProdutoID { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; } = null!;

    }
}