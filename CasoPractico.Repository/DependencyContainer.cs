using CasoPractico.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CasoPractico.Repository
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IRepositoryManager, RepositoryManager>();
            services.AddDbContextFactory<TransactionsDbContext>(options => options.UseSqlite(configuration.GetConnectionString("SqliteConnection")));
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IMovimentRepository, MovimentRepository>();
            services.AddScoped<IAccountRepository, AccountRepository>();
            return services;
        }
    }
}
