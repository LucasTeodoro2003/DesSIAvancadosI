namespace aula11_EF.Models
{
   public class Cliente{

    private int id;
    private string nome = "";
    private int idade;

    public string Nome{
        get {return nome;}
        set{nome = value;}
    }

    public int Idade{
        get {return idade;}
        set {idade = value;}
    }

    public int Id{
        get{return id;}
        set{id = value;}
    }

    public Cliente(string nome, int idade){
        Nome = nome;
        Idade = idade;
    }

    public override string ToString(){
        return $"Nome: {Nome}, Idade: {Idade}";
    } 

}
}