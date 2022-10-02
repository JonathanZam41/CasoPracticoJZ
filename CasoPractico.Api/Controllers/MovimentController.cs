using CasoPractico.Application.DTO.Moviments;
using CasoPractico.Application.Features.Moviments.Commands.Create;
using CasoPractico.Application.Features.Moviments.Queries.MovimentsByAccountIdAndDate;
using CasoPractico.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CasoPractico.Api.Controllers
{
    [ControllerName("Movimientos")]
    [ApiController]
    [Route("api/movimientos")]
    public class MovimentController: ControllerBase
    {
        private readonly ISender _sender;

        public MovimentController(ISender sender)
        {
            _sender = sender;
        }

        /// <summary>
        /// Obtiene movimientos de una cuenta por fechas
        /// </summary>
        /// <returns>retorna una lista de movimientos para reportes</returns>
        [HttpGet("{idAccount}&{initialDate}&{finalDate}")]
        public async Task<ActionResult<IReadOnlyCollection<Moviment>>> GetMovimentsByAccountIdAndDate(int idAccount, DateTime initialDate, DateTime finalDate)
        {
            var moviment = await _sender.Send(new GetMovimentsByAccountIdAndDateQuery(trackChanges: false, idAccount, initialDate, finalDate));
            return Ok(moviment);
        }

        /// <summary>
        /// Inserta un nuevo cliente
        /// </summary>
        /// <param name="moviment">movimiento a guardar</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateClient([FromBody] MovimentForCreationDto moviment)
        {
            await _sender.Send(new CreateMovimentCommand(moviment));
            return Ok();
        }
    }
}
