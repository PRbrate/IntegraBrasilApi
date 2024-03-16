using IntegraBrasilApi.DTOs;

namespace FrontApi.Services
{
    public interface IEnderecosService
    {
        Task<EnderecoDto> BuscarEndereco(string cep);
    }
}
