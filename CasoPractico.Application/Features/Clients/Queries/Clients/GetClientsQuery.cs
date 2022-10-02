using CasoPractico.Application.DTO.Clients;
using MediatR;

namespace CasoPractico.Application.Features.Clients.Queries.Clients
{
    public sealed record GetClientsQuery(bool trackChanges) : IRequest<IReadOnlyCollection<ClientDto>>
    {
    }
}
