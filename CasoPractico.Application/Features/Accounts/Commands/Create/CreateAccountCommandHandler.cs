using CasoPractico.Contracts.Enum;
using CasoPractico.Contracts.Persistence;
using CasoPractico.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoPractico.Application.Features.Accounts.Commands.Create
{
    internal class CreateAccountCommandHandler : IRequestHandler<CreateAccountCommand, int>
    {
        private readonly IRepositoryManager _repository;
        public CreateAccountCommandHandler(IRepositoryManager repositoryManager)
        {
            _repository = repositoryManager;
        }
        public async Task<int> Handle(CreateAccountCommand request, CancellationToken cancellationToken)
        {
            Account account = new Account()
            {
                Number = request.account.Number,
                CreatedBy = request.account.CreatedBy,
                InitialBalance = request.account.InitialBalance,
                Type = request.account.Type,
                Status = (ushort)Status.Active,
                IdClient = request.account.IdClient,
            };

            _repository.Account.Create(account);
            await _repository.SaveAsync();
            return 0;
        }
    }
}
