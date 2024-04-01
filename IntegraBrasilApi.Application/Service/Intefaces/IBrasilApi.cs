using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Entities;

namespace IntegraBrasilApi.Service.Intefaces
{
    public interface IBrasilApi 
    {
        Task<ResponseGeneric<Endereco>> GetEndereco(string cep);
        Task<ResponseGeneric<List<Banco>>> GetBancos();
        Task<ResponseGeneric<Banco>> GetBancoId(string codigoBanco);

        Task<ResponseGeneric<Cnpj>> GetCnpj(string cnpj);
    }
}
