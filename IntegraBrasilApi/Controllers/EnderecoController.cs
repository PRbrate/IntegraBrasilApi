using IntegraBrasilApi.Service.Intefaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace IntegraBrasilApi.Controllers
{
    [ApiController]
    [Route("api/endereco")]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }


        [HttpGet("buscar/{cep}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarEndereco([FromRoute] string cep)
        {
            if (cep.Length != 8)
            {
                return BadRequest("O cep deve conter 8 caracteres");
            }
            else
            {
                var response = await _enderecoService.GetEnderecoDto(cep);

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
