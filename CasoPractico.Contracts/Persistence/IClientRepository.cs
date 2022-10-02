using CasoPractico.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoPractico.Contracts.Persistence
{
    public interface IClientRepository : IRepositoryForWrite<Client>, IRepositoryForRead<Client>
    {
        Task<IReadOnlyCollection<Client>> GetAllClientsAsync(bool trackChanges, CancellationToken cancellationToken);

        Task<Client> GetClientByIdAsync(bool trackChanges, int id, CancellationToken cancellationToken);
    }
}
