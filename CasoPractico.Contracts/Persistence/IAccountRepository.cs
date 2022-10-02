using CasoPractico.Domain;

namespace CasoPractico.Contracts.Persistence
{
    public interface IAccountRepository : IRepositoryForWrite<Account>, IRepositoryForRead<Account>
    {
        Task<IReadOnlyCollection<Account>> GetAccountByClientIdAsync(bool trackChanges, int ClientID, CancellationToken cancellationToken);
    }
}
