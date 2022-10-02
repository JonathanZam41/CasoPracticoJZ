using CasoPractico.Application.DTO.Moviments;
using MediatR;

namespace CasoPractico.Application.Features.Moviments.Commands.Create
{
    public sealed record CreateMovimentCommand(MovimentForCreationDto moviment) : IRequest<int>
    {

    }
}
