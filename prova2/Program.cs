using Microsoft.EntityFrameworkCore;
using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var aluno1 = new Aluno { Nome = "Lucas Teodoro", Matricula = "123456", Idade = 21, };
                var aluno2 = new Aluno { Nome = "Willian Ribeiro", Matricula = "684523", Idade = 22,};

                var disciplina1 = new Disciplina { NomeDisciplina = "Redes com Henaldao", CodigoDisciplina = "69"};
                var disciplina2 = new Disciplina { NomeDisciplina = "Desenvolvimento com Rafael",  CodigoDisciplina = "102"};

                aluno1.Disciplinas.Add(disciplina1);
                aluno2.Disciplinas.Add(disciplina2);
                aluno1.Disciplinas.Add(disciplina2);
                aluno2.Disciplinas.Add(disciplina1);
                context.Alunos.AddRange(aluno1, aluno2);
                context.Disciplinas.AddRange(disciplina1, disciplina2);
                context.SaveChanges();

                var alunos = context.Alunos.Include(p => p.Disciplinas).ToList();
                foreach (var aluno in alunos)
                {
                    Console.WriteLine($"Alunos: {aluno.Nome}");
                    foreach (var disciplina in aluno.Disciplinas)
                    {
                        Console.WriteLine($"Disciplinas: {disciplina.NomeDisciplina}");
                    }
                }
            }
        }
    }
