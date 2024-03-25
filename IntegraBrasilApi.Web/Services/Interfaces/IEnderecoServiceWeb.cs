using IntegraBrasilApi.DTOs;

namespace IntegraBrasilApi.Web.Services.Interfaces
{
    public interface IEnderecoServiceWeb
    {
        Task<EnderecoDto> endereco(string cep);
    }
}
