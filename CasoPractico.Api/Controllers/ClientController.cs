using CasoPractico.Application.DTO.Clients;
using CasoPractico.Application.Features.Clients.Commands.Create;
using CasoPractico.Application.Features.Clients.Queries.Clients;
using CasoPractico.Application.Features.Clients.Queries.ClientsById;
using CasoPractico.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CasoPractico.Api.Controllers
{
    [ControllerName("Clientes")]
    [ApiController]
    [Route("api/clientes")]
    public class ClientController : ControllerBase
    {
        private readonly ISender _sender;

        public ClientController(ISender sender)
        {
            _sender = sender;
        }

        /// <summary>
        /// Obtiene una lista de clientes
        /// </summary>
        /// <returns>retorna una lista de cliente</returns>
        [HttpGet]
        public async Task<ActionResult<IReadOnlyCollection<Client>>> GetAllClients()
        {
            IReadOnlyCollection<ClientDto> clients = await _sender.Send(new GetClientsQuery(trackChanges: false));
            return Ok(clients);
        }

        /// <summary>
        /// Obtiene cliente por id
        /// </summary>
        /// <returns>retorna una lista de cliente</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<IReadOnlyCollection<Client>>> GetAllClientsById(int id)
        {
            ClientDto client = await _sender.Send(new GetClientByIdQuery(trackChanges: false, id));
            return Ok(client);
        }

        /// <summary>
        /// Inserta un nuevo cliente
        /// </summary>
        /// <param name="client">cliente a guardar</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateClient([FromBody] ClientForCreationDto client)
        {
            await _sender.Send(new CreateClientCommand(client));
            return Ok();
        }

        //[HttpPut]
        //public async Task<IActionResult> UpdateClientById()
        //{
        //    await _sender.Send(new CreateClientCommand());
        //    return Ok();
        //}

        //[HttpDelete]
        //public async Task<IActionResult> DeleteClientById()
        //{
        //    await _sender.Send(new CreateClientCommand());
        //    return Ok();
        //}
    }
}
