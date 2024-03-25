using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Entities;

namespace IntegraBrasilApi.Service.Intefaces
{
    public interface IEnderecoService
    {
        Task<ResponseGeneric<EnderecoDto>> GetEnderecoDto(string cep);
    }
}
