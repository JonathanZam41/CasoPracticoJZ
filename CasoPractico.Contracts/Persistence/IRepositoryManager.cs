using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoPractico.Contracts.Persistence
{
    public interface IRepositoryManager
    {
        IClientRepository Client { get; }

        IMovimentRepository Moviment { get; }

        IAccountRepository Account { get; }

        Task<int> SaveAsync(CancellationToken cancellationToken = default);
    }
}
