using CasoPractico.Application.DTO.Clients;
using CasoPractico.Contracts.Persistence;
using MediatR;

namespace CasoPractico.Application.Features.Clients.Queries.Clients
{
    internal class GetClientsHandler : IRequestHandler<GetClientsQuery, IReadOnlyCollection<ClientDto>>
    {
        private readonly IRepositoryManager _repository;
        public GetClientsHandler(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task<IReadOnlyCollection<ClientDto>> Handle(GetClientsQuery request, CancellationToken cancellationToken)
        {
            var items = await _repository.Client.GetAllClientsAsync(false, cancellationToken);
            if (items.Any() is false)
            {
                throw new Exception();
            }
            
            return items.Select(x => new ClientDto {
                Address = x.Address,
                Age = x.Age,
                Gender = x.Gender,
                Identification = x.Identification,
                Name = x.Name,
                Phone = x.Phone
            }).ToList();
        }
    }
}
