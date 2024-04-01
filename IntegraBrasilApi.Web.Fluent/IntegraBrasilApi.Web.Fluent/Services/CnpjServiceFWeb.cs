using IntegraBrasilApi.Application.DTOs;
using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Web.Services.Interfaces;
using System.Net;

namespace IntegraBrasilApi.Web.Fluent.Services
{
    public class CnpjServiceFWeb : ICnpjService
    {
        public HttpClient _httpCliet;
        public ILogger<EnderecoDto> _logger;

        public CnpjServiceFWeb(HttpClient httpCliet, ILogger<EnderecoDto> logger)
        {
            _httpCliet = httpCliet;
            _logger = logger;
        }

        public async Task<CnpjDto> GetCnpj(string cnpj)
        {
            try
            {

                var response = await _httpCliet.GetAsync($"api/cnpj/buscar/{cnpj}");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == HttpStatusCode.NoContent)
                    {
                        return default(CnpjDto);
                    }
                    return await response.Content.ReadFromJsonAsync<CnpjDto>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    return new CnpjDto();
                }
            }
            catch (Exception)
            {
                _logger.LogError($"Erro ao obter o endereco pelo Id: {cnpj}");
                throw;
            }
        }
    }
}
