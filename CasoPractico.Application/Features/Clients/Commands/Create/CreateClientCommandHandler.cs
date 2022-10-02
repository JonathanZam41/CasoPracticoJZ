using CasoPractico.Contracts.Enum;
using CasoPractico.Contracts.Persistence;
using CasoPractico.Domain;
using MediatR;

namespace CasoPractico.Application.Features.Clients.Commands.Create
{
    internal class CreateClientCommandHandler : IRequestHandler<CreateClientCommand, int>
    {
        private readonly IRepositoryManager _repository;
        public CreateClientCommandHandler(IRepositoryManager repositoryManager)
        {
            _repository = repositoryManager;
        }
        public async Task<int> Handle(CreateClientCommand request, CancellationToken cancellationToken)
        {
            Client client = new Client()
            {
                Password = request.client.Password,
                Address = request.client.Address,
                Age = request.client.Age,
                Gender = request.client.Gender,
                Identification = request.client.Identification,
                Name = request.client.Name,
                Phone = request.client.Phone,
                Status = (ushort)Status.Active,
                CreatedBy = request.client.CreatedBy,
                CreatedOn = DateTime.Now,
            };

            _repository.Client.Create(client);
            await _repository.SaveAsync();
            return 0;
        }
    }
}
