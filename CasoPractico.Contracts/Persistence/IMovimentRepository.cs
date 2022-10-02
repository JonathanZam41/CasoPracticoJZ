using CasoPractico.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoPractico.Contracts.Persistence
{
    public interface IMovimentRepository : IRepositoryForWrite<Moviment>, IRepositoryForRead<Moviment>
    {
        Task<IReadOnlyCollection<Moviment>> GetMovimentsByAccountIdAndDate(bool trackChanges, int AccountId, DateTime InitialDate, DateTime FinalDate, CancellationToken cancellationToken);
    }
}
