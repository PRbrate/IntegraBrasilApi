using IntegraBrasilApi.Service.Intefaces;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace IntegraBrasilApi.Controllers
{
    [ApiController]
    [Route("api/banco/")]    
    public class BancoController : ControllerBase
    {
        private readonly IBancoService _bancoService;

        public BancoController(IBancoService bancoService)
        {
            _bancoService = bancoService;
        }

        [HttpGet("get/Bancos")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetTodosBancos()
        {
            var bancos = await _bancoService.GetBancos();
            if(bancos.StatusCode == HttpStatusCode.OK) 
            {
                return Ok(bancos.DataReturn);
            }
            else
            {
                return StatusCode((int)bancos.StatusCode, bancos.ErroRetorno);
            }
        }

        [HttpGet("getBancosId{codigo}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetBancosId([RegularExpression("^[0-9]*$")] string codigo)
        {
            var banco = await _bancoService.GetBancoId(codigo);

            if (banco.StatusCode == HttpStatusCode.OK)
            {
                return Ok(banco);
            }
            else
            {
                return StatusCode((int)banco.StatusCode, banco.ErroRetorno);
            }
        }
    }
}
