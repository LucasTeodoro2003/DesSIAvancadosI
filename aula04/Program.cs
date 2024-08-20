class Program
{
    public static void Main(string[] args)
    {
        Pessoa objPessoa = new Pessoa("Lucas");
        PessoaStruct objPessoaStruct = new PessoaStruct("Lucas Struct");
        Console.WriteLine($@"Antes do método (Classe):
                        {objPessoa.ToString()}");
        // Console.WriteLine("Antes do método (Classe):" + objPessoa.ToString());
        alterarNomeClasse(objPessoa);
        Console.WriteLine($@"Depois do método (Classe):
                        {objPessoa.ToString()}");      

        // Struct                                 
        Console.WriteLine($@"Antes do método (Struct):
                        {objPessoaStruct.ToString()}");
        alterarNomeClasseStruct(objPessoaStruct);
        Console.WriteLine($@"Antes do método (Struct):
                        {objPessoaStruct.ToString()}");
    }

    public static void alterarNomeClasse(Pessoa objAux)
    {
        objAux.Nome = "Willian";
    }

    public static void alterarNomeClasseStruct(PessoaStruct objAux){
        objAux.NomeStruct = "Willian Struct";
        Console.WriteLine($"\n \n Dentro do método Struct: {objAux.NomeStruct}\n\n");
    }
}