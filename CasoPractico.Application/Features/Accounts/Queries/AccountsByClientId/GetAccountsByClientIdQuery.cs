using CasoPractico.Application.DTO.Accounts;
using MediatR;

namespace CasoPractico.Application.Features.Accounts.Queries.AccountsByClientId
{
    public sealed record GetAccountsByClientIdQuery(bool trackChanges, int ClientId) : IRequest<IReadOnlyCollection<AccountForSelectDto>>
    {
    }
}
