using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Entities;

namespace IntegraBrasilApi.Service.Intefaces
{
    public interface IBancoService
    {
        Task<ResponseGeneric<List<BancoDto>>> GetBancos();
        Task<ResponseGeneric<BancoDto>> GetBancoId(string codigoBanco);
    }
}
