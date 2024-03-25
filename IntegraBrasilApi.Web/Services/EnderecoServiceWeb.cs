using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Web.Services.Interfaces;
using System.Net;
using System.Net.Http.Json;

namespace IntegraBrasilApi.Web.Services
{
    public class EnderecoServiceWeb : IEnderecoServiceWeb
    {
        public HttpClient _httpCliet;
        public ILogger<EnderecoDto> _logger;

        public EnderecoServiceWeb(HttpClient httpCliet, ILogger<EnderecoDto> logger)
        {
            _httpCliet = httpCliet;
            _logger = logger;
        }

        public async Task<EnderecoDto> endereco(string cep)
        {
            try{

                var response = await _httpCliet.GetAsync($"api/endereco/{cep}");

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
                    _logger.LogError($"Erro a obter Endereço pelo id = {cep} - {message}");
                    throw new Exception($"Status Code: {response.StatusCode} - {message}");
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
