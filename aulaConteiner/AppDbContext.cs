using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext {
    public DbSet<Pessoa> Pessoas {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseNpgsql("Host=localhost;Database=pessoas.db;Username=admin;Password=admin123");
    }
}