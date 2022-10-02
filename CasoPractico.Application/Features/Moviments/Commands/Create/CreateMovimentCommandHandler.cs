using CasoPractico.Contracts.Enum;
using CasoPractico.Contracts.Persistence;
using CasoPractico.Domain;
using MediatR;

namespace CasoPractico.Application.Features.Moviments.Commands.Create
{
    internal class CreateMovimentCommandHandler : IRequestHandler<CreateMovimentCommand, int>
    {
        private readonly IRepositoryManager _repository;
        public CreateMovimentCommandHandler(IRepositoryManager repositoryManager)
        {
            _repository = repositoryManager;
        }
        public async Task<int> Handle(CreateMovimentCommand request, CancellationToken cancellationToken)
        {

            Moviment moviment = new Moviment()
            {
                Date = request.moviment.Date,
                Type = request.moviment.Type,
                Value = request.moviment.Value,
                Balance = request.moviment.Balance,
                IdAccount = request.moviment.IdAccount,
                CreatedBy = request.moviment.CreatedBy,
                CreatedOn = DateTime.Now,
                Status = (ushort)Status.Active
            };

            _repository.Moviment.Create(moviment);
            await _repository.SaveAsync();
            return 0;
        }
    }
}
