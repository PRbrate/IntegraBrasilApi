using IntegraBrasilApi.DTOs;

namespace FrontApi.Services
{
    public class EnderecoService : IEnderecosService
    {
        private readonly HttpClient _httpClient;
        public ILogger<EnderecoDto> _logger;

        public EnderecoService(HttpClient httpClient, ILogger<EnderecoDto> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<EnderecoDto> BuscarEndereco(string cep)
        {
            try 
            {
                var enderecoDto = await _httpClient.GetFromJsonAsync<EnderecoDto>($"api/endereco/{cep}");

                return enderecoDto;
            }
            catch (Exception ex)
            {
                _logger.LogError("Erro ao Acessar endereco: api/endereco");
                throw;
            }
            
        }
    }
}
