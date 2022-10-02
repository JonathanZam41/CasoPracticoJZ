using CasoPractico.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoPractico.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly TransactionsDbContext _repositoryContext;
        private readonly Lazy<IClientRepository> _clientRepository;
        private readonly Lazy<IMovimentRepository> _movimentRepository;
        private readonly Lazy<IAccountRepository> _accountRepository;
        public RepositoryManager(IDbContextFactory<TransactionsDbContext> repositoryContext)
        {
            _repositoryContext = repositoryContext.CreateDbContext();
            _clientRepository = new Lazy<IClientRepository>(() => new ClientRepository(_repositoryContext));
            _movimentRepository = new Lazy<IMovimentRepository>(() => new MovimentRepository(_repositoryContext));
            _accountRepository = new Lazy<IAccountRepository>(() => new AccountRepository(_repositoryContext));
        }
        public IClientRepository Client => _clientRepository.Value;

        public IMovimentRepository Moviment => _movimentRepository.Value;

        public IAccountRepository Account => _accountRepository.Value;

        public Task<int> SaveAsync(CancellationToken cancellationToken = default) => _repositoryContext.SaveChangesAsync(cancellationToken);

    }
}
