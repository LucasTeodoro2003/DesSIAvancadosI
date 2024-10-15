using Microsoft.EntityFrameworkCore;

namespace aula12_TPT{

    public class AppDbContext : DbContext{
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Aluno> Alunos {get; set;}
        public DbSet<Professor> Professores {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlite("Data Source=pessoas.db");
        }
        
        //No método OnModelCreating, utilizamos HasDiscriminator para definir uma coluna de discriminação,
        //chamada PessoaTipo, que indica o tipo de pessoa (Aluno ou Professor) na tabela única
        //Tabela Única por Hierarquia (TPH - Table per Hierarchy)

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Pessoa>()
                        .HasDiscriminator<string>("PessoaTipo")
                        .HasValue<Aluno>("Aluno")
                        .HasValue<Professor>("Professor");
        }
    }
}