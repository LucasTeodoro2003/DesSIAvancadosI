public class Disciplina {
    public int Id {get; set;}
    public string NomeDisciplina {get; set;}
    public string CodigoDisciplina {get; set;}
    public IList<Aluno> Alunos {get; set;} = new List<Aluno>();

}