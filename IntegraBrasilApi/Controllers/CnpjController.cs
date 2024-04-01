using IntegraBrasilApi.Application.Service.Intefaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Runtime.ConstrainedExecution;

namespace IntegraBrasilApi.Controllers
{
    [Route("api/cnpj/")]
    [ApiController]
    public class CnpjController : ControllerBase
    {
        private readonly ICnpjService _cnpjService;

        public CnpjController(ICnpjService cnpjService)
        {
            _cnpjService = cnpjService;
        }

        [HttpGet("buscar/{cnpj}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> BuscarCnpj(string cnpj) 
        {
            if(cnpj.Length != 14)
            {
                return BadRequest("O CNPJ deve conter 14 dígitos");
            }
            else
            {
                var response = await _cnpjService.GetCnpj(cnpj);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return Ok(response.DataReturn);
                }
                else
                {
                    return StatusCode((int)response.StatusCode, response.ErroRetorno);
                }
            }
        }

    }
}
