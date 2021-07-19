using Microsoft.EntityFrameworkCore;

namespace Alura.Loja.Testes.ConsoleApp
{
    // Configuração necessária para utilizar o Entity no projeto
    public class LojaContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LojaDB;Trusted_Connection=true;");
        }
    }
}