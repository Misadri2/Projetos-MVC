using Microsoft.EntityFrameworkCore;
using aula1.Models;
namespace aula1.DataBase
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Funcionario> Funcionarios {get; set; }
        public DbSet<Categoria> Categorias {get; set; }
        public DbSet<Produto> Produto {get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base (options) {}

        //OnConfiguring é onde você colocar configurações no seu contexto com banco de dados
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){ 
            optionsBuilder.UseLazyLoadingProxies();
        }*/
        //usado para fazer customização nas tabelas 
       /* protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Produto>().ToTable("Produtos Mislaine"); //--> Muda nome da tabela
            modelBuilder.Entity<Produto>().Property(p => p.Nome).IsRequired();
        }*/
    }
}