using ModelDomain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Database.Context
{
    public class Contexto : IdentityDbContext<Usuario, IdentityRole<int>, int> 
    {
        private readonly IConfiguration config;

        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<CategoriaAnimais> CategoriasDeAnimais { get; set; }
        public DbSet<AnimalDomestico> animalDomesticos { get; set; }
        public DbSet<Autenticacao> Autenticacao { get; set; }
        public Contexto()
        {

        }
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var connectionString = config.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SecondyLifeTeste;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
        }
    }
}
