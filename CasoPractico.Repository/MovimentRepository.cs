using CasoPractico.Contracts.Persistence;
using CasoPractico.Domain;
using Microsoft.EntityFrameworkCore;

namespace CasoPractico.Repository
{
    public class MovimentRepository : RepositoryBase<Moviment>, IMovimentRepository
    {
        public MovimentRepository(TransactionsDbContext repositoryContext) : base(repositoryContext)
        {
        }

        /// <summary>
        ///  Obtiene una lista de movimientos de las cuentas de un ClientId
        /// </summary>
        /// <param name="trackChanges"></param>
        /// <returns>Lista de registros obtenidos</returns>
        public async Task<IReadOnlyCollection<Moviment>> GetMovimentsByAccountIdAndDate(bool trackChanges, int AccountId, DateTime InitialDate, DateTime FinalDate, CancellationToken cancellationToken)
        {
            var items = await GetByCondition(x => x.IdAccount.Equals(AccountId) && x.Date.Date >= InitialDate.Date && x.Date.Date <= FinalDate.Date, trackChanges)
                .Include(c => c.Account)
                .Include(e => e.Account.Client)
                .ToListAsync(cancellationToken);
            return items;
        }
    }
}
