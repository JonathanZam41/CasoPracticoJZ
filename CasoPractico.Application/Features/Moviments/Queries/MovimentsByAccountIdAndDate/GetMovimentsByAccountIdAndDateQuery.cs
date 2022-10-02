using CasoPractico.Application.DTO.Moviments;
using MediatR;

namespace CasoPractico.Application.Features.Moviments.Queries.MovimentsByAccountIdAndDate
{
    public sealed record GetMovimentsByAccountIdAndDateQuery(bool trackChanges, int AccountId, DateTime InitialDate, DateTime FinalDate) : IRequest<IReadOnlyCollection<MovimentForSelectDto>>
    {
    }
}
