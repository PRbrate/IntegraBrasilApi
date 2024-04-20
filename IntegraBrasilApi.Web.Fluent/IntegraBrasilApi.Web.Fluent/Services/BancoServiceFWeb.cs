using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Web.Fluent.Services.Interface;
using System.Net;

namespace IntegraBrasilApi.Web.Fluent.Services
{
    public class BancoServiceFWeb : IBancoService
    {
        public HttpClient _httpCliet;
        public ILogger<BancoDto> _logger;

        public BancoServiceFWeb(HttpClient httpCliet, ILogger<BancoDto> logger)
        {
            _httpCliet = httpCliet;
            _logger = logger;
        }
        public async Task<BancoDto> banco(string codigo)
        {
            try
            {

                var response = await _httpCliet.GetAsync($"api/banco/getBancosId{codigo}");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == HttpStatusCode.NoContent)
                    {
                        return default(BancoDto);
                    }
                    return await response.Content.ReadFromJsonAsync<BancoDto>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    return new BancoDto();
                }
            }
            catch (Exception)
            {
                _logger.LogError($"Erro ao obter o endereco pelo Id: {banco}");
                throw;
            }
        }
    }
}
