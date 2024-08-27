public class Pessoa
{
    private string? nome;
    private double nota;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public double Nota
    {
        get { return nota; }
        set { nota = value; }
    }

    public Pessoa(string nome, double nota)
    {
        Nome = nome;
        Nota = nota;
    }

    public override string ToString(){
        return $"Nome: {Nome}, Nota: {Nota}";
    }
}