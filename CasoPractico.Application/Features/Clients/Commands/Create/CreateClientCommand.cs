using CasoPractico.Application.DTO.Clients;
using MediatR;

namespace CasoPractico.Application.Features.Clients.Commands.Create
{
    public sealed record CreateClientCommand(ClientForCreationDto client) : IRequest<int>
    {

    }
}
