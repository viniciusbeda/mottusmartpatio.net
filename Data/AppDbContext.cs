using Microsoft.EntityFrameworkCore;
using MottuSmartPatio.Models;

namespace MottuSmartPatio.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Moto> Motos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Moto>().HasData(
                new Moto { Id = 1, Placa = "ABC1234", Modelo = "Honda CG 160", Status = "Disponível" },
                new Moto { Id = 2, Placa = "DEF5678", Modelo = "Yamaha Fazer 250", Status = "Em manutenção" },
                new Moto { Id = 3, Placa = "GHI9012", Modelo = "Honda Biz 125", Status = "Disponível" }
            );
        }
    }
}
