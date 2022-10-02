using CasoPractico.Application.DTO.Accounts;
using CasoPractico.Contracts.Persistence;
using MediatR;

namespace CasoPractico.Application.Features.Accounts.Queries.AccountsByClientId
{
    internal class GetAccountsByClientIdHandler : IRequestHandler<GetAccountsByClientIdQuery, IReadOnlyCollection<AccountForSelectDto>>
    {
        private readonly IRepositoryManager _repository;
        public GetAccountsByClientIdHandler(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task<IReadOnlyCollection<AccountForSelectDto>> Handle(GetAccountsByClientIdQuery request, CancellationToken cancellationToken)
        {
            var item = await _repository.Account.GetAccountByClientIdAsync(false, request.ClientId, cancellationToken);

            if (item.Any() is false)
            {
                throw new Exception("No hay cuentas registradas para este cliente");
            }

            return item.Select(x => new AccountForSelectDto
            {
                InitialBalance = x.InitialBalance,
                Number = x.Number,
                Type = x.Type,
                ClientNames = x.Client.Name                
            }).ToList();
        }
    }
}
