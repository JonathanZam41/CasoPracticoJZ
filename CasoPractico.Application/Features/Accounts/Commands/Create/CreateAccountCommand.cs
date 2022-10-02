using CasoPractico.Application.DTO.Accounts;
using MediatR;

namespace CasoPractico.Application.Features.Accounts.Commands.Create
{
    public sealed record CreateAccountCommand(AccountForCreationDto account) : IRequest<int>
    {

    }
}
