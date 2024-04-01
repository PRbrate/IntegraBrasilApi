using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Web.Services.Interfaces;
using System.Net;
using System.Net.Http.Json;

namespace IntegraBrasilApi.Web.Services
{
    public class EnderecoServiceFWeb : IEnderecoServiceFWeb
    {
        public HttpClient _httpCliet;
        public ILogger<EnderecoDto> _logger;

        public EnderecoServiceFWeb(HttpClient httpCliet, ILogger<EnderecoDto> logger)
        {
            _httpCliet = httpCliet;
            _logger = logger;
        }

        public async Task<EnderecoDto> endereco(string cep)
        {
            try{

                var response = await _httpCliet.GetAsync($"api/endereco/buscar/{cep}");

                if (response.IsSuccessStatusCode) 
                {
                    if (response.StatusCode == HttpStatusCode.NoContent) 
                    {
                        return default(EnderecoDto);
                    }
                    return await response.Content.ReadFromJsonAsync<EnderecoDto>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    return new EnderecoDto();
                }
            }
            catch(Exception)
            {
                _logger.LogError($"Erro ao obter o endereco pelo Id: {cep}");
                throw;
            }

            
        }
    }
}
