using CasoPractico.Contracts.Persistence;
using CasoPractico.Domain;
using Microsoft.EntityFrameworkCore;

namespace CasoPractico.Repository
{
    public class AccountRepository:  RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(TransactionsDbContext repositoryContext) : base(repositoryContext)
        {
        }

        /// <summary>
        ///  Obtiene una lista de cuentas en base al ClientId
        /// </summary>
        /// <param name="trackChanges"></param>
        /// <returns>Lista de registros obtenidos</returns>
        public async Task<IReadOnlyCollection<Account>> GetAccountByClientIdAsync(bool trackChanges, int ClientId, CancellationToken cancellationToken)
        {
            var items = await GetByCondition(x => x.IdClient.Equals(ClientId), trackChanges)
                .Include(c => c.Client)
                .ToListAsync(cancellationToken);
            return items;
        }
    }
}
