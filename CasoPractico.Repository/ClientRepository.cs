using CasoPractico.Contracts.Persistence;
using CasoPractico.Domain;
using Microsoft.EntityFrameworkCore;

namespace CasoPractico.Repository
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
        public ClientRepository(TransactionsDbContext repositoryContext) : base(repositoryContext)
        {
        }

        /// <summary>
        ///  Obtiene una lista en base al tipo de transaccion
        /// </summary>
        /// <param name="trackChanges"></param>
        /// <returns>Lista de registros obtenidos</returns>
        public async Task<IReadOnlyCollection<Client>> GetAllClientsAsync(bool trackChanges, CancellationToken cancellationToken)
        {
            var items = await GetAllAsync(trackChanges).ToListAsync(cancellationToken);

            return items;
        }

        /// <summary>
        ///  Obtiene una lista en base al tipo de transaccion
        /// </summary>
        /// <param name="trackChanges"></param>
        /// <returns>Lista de registros obtenidos</returns>
        public async Task<Client> GetClientByIdAsync(bool trackChanges, int id, CancellationToken cancellationToken)
        {
            var query = GetByCondition(x => x.Id.Equals(id), trackChanges);

            var item = await query.FirstOrDefaultAsync();

            if (item is null)
            {
                throw new Exception();
            }
            return item;
        }
    }
}
