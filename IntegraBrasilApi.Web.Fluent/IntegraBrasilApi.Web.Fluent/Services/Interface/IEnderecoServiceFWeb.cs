using IntegraBrasilApi.DTOs;

namespace IntegraBrasilApi.Web.Services.Interfaces
{
    public interface IEnderecoServiceFWeb
    {
        Task<EnderecoDto> endereco(string cep);
    }
}
