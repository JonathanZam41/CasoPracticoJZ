using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CasoPractico.Repository
{
    class TransactionsDbContextFactory : IDesignTimeDbContextFactory<TransactionsDbContext>
    {
        public TransactionsDbContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<TransactionsDbContext>();
            optionBuilder.UseSqlite("Data Source=D:\\Works\\Transaction.db;");

            return new TransactionsDbContext(optionBuilder.Options);
        }
    }
}
