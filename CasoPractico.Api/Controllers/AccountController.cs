using CasoPractico.Application.DTO.Accounts;
using CasoPractico.Application.Features.Accounts.Commands.Create;
using CasoPractico.Application.Features.Accounts.Queries.AccountsByClientId;
using CasoPractico.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CasoPractico.Api.Controllers
{
    [ControllerName("Cuentas")]
    [ApiController]
    [Route("api/cuentas")]
    public class AccountController: ControllerBase
    {
        private readonly ISender _sender;

        public AccountController(ISender sender)
        {
            _sender = sender;
        }

        /// <summary>
        /// Lista de cuentas del client
        /// </summary>
        /// <param name="id">id Cliente</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<IReadOnlyCollection<Account>>> GetAllAccounts(int id)
        {
            var accounts = await _sender.Send(new GetAccountsByClientIdQuery(trackChanges: false, id));
            return Ok(accounts);
        }

        ///// <summary>
        ///// Obtiene cliente por id
        ///// </summary>
        ///// <returns>retorna una lista de cliente</returns>
        //[HttpGet("{id}")]
        //public async Task<ActionResult<IReadOnlyCollection<Client>>> GetAllClientsById(int id)
        //{
        //    Account account = await _sender.Send(new GetClientByIdQuery(trackChanges: false, id));
        //    return Ok(account);
        //}

        /// <summary>
        /// Inserta un nuevo cliente
        /// </summary>
        /// <param name="account">cliente a guardar</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateAccount([FromBody] AccountForCreationDto account)
        {
            await _sender.Send(new CreateAccountCommand(account));
            return Ok();
        }
    }
}
