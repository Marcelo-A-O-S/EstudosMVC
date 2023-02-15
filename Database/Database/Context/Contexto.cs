using ModelDomain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Database.Context
{
    public class Contexto : IdentityDbContext<Usuario>
    {
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<CategoriaAnimais> CategoriasDeAnimais { get; set; }
        public DbSet<AnimalDomestico> animalDomesticos { get; set; }
        public DbSet<Autenticacao> Autenticacao { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SecondyLife;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
        }
    }
}
