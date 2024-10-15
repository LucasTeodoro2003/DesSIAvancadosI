namespace aula13_OTO{
    public class Pessoa{
        public int PessoaId {get; set;}
        public string Nome {get; set;} = string.Empty;
        //Relacionamento 1:1
        public Endereco Endereco {get; set;} = null;
    }
}