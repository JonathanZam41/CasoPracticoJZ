using CasoPractico.Application.DTO.Clients;
using CasoPractico.Contracts.Persistence;
using CasoPractico.Domain;
using MediatR;

namespace CasoPractico.Application.Features.Clients.Queries.ClientsById
{
    internal class GetClientByIdHandler : IRequestHandler<GetClientByIdQuery, ClientDto>
    {
        private readonly IRepositoryManager _repository;
        public GetClientByIdHandler(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task<ClientDto> Handle(GetClientByIdQuery request, CancellationToken cancellationToken)
        {
            Client item = await _repository.Client.GetClientByIdAsync(false, request.id, cancellationToken);

            ClientDto client = new ClientDto
            {
                Name = item.Name,
                Phone = item.Phone,
                Address = item.Address,
                Age = item.Age,
                Identification = item.Identification,
                Gender = item.Gender,
            };
            return client;
        }
    }
}
