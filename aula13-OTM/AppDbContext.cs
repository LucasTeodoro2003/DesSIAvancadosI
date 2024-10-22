using Microsoft.EntityFrameworkCore;
namespace aula13_OTM {
    public class AppDbContext : DbContext {
        public DbSet<Categoria> Categorias { get; set; } = null!;
        public DbSet<Produtos> Produtos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite("Data Source=relacionamento.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
    modelBuilder.Entity<Produtos>()
        .HasKey(p => p.ProdutoID);

    modelBuilder.Entity<Produtos>()
        .HasOne(p => p.Categoria)
        .WithMany(c => c.Produtos)
        .HasForeignKey(p => p.CategoriaId);
}
    }
}