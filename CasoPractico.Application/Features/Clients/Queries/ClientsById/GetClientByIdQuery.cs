using CasoPractico.Application.DTO.Clients;
using MediatR;

namespace CasoPractico.Application.Features.Clients.Queries.ClientsById
{
    public sealed record GetClientByIdQuery(bool trackChanges, int id) : IRequest<ClientDto>
    {
    }
}
