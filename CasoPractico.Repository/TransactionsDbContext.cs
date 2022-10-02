using CasoPractico.Domain;
using CasoPractico.Repository.Configurations;
using Microsoft.EntityFrameworkCore;

namespace CasoPractico.Repository
{
    public sealed class TransactionsDbContext : DbContext
    {
        public TransactionsDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Moviment> Moviments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountConfiguration());

            modelBuilder.ApplyConfiguration(new ClientConfiguration());

            modelBuilder.ApplyConfiguration(new MovimentConfiguration());
        }
    }
}
