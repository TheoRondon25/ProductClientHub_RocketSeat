using Microsoft.EntityFrameworkCore;
using ProductClientHub.API.Entities;

namespace ProductClientHub.API.Infraestruture
{
    public class ProductClientHubDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; } = default!;
        public DbSet<Product> Products { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Projetos\\Curso_RocketSeat\\ProductClientHubDB.db");
        }
    }
}
