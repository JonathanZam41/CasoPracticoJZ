using CasoPractico.Application.DTO.Moviments;
using CasoPractico.Contracts.Persistence;
using MediatR;

namespace CasoPractico.Application.Features.Moviments.Queries.MovimentsByAccountIdAndDate
{
    internal class GetMovimentsByAccountIdAndDateHandler : IRequestHandler<GetMovimentsByAccountIdAndDateQuery, IReadOnlyCollection<MovimentForSelectDto>>
    {
        private readonly IRepositoryManager _repository;
        public GetMovimentsByAccountIdAndDateHandler(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task<IReadOnlyCollection<MovimentForSelectDto>> Handle(GetMovimentsByAccountIdAndDateQuery request, CancellationToken cancellationToken)
        {
            var item = await _repository.Moviment.GetMovimentsByAccountIdAndDate(false, request.AccountId, request.InitialDate, request.FinalDate, cancellationToken);

            if (item.Any() is false)
            {
                throw new Exception("No hay movimientos registrados");
            }

            return item.Select(x => new MovimentForSelectDto
            {
                Date = x.Date,
                ClientNames = x.Account.Client.Name,
                AccountNumber = x.Account.Number,
                AccountType = x.Account.Type,
                InitialBalance = x.Account.InitialBalance,
                Status = x.Status,
                Value = x.Value,
                Balance = x.Balance,
            }).ToList();
        }
    }
}
