using IntegraBrasilApi.Application.DTOs;

namespace IntegraBrasilApi.Web.Services.Interfaces
{
    public interface ICnpjService
    {
        Task<CnpjDto> GetCnpj(string cnpj);
    }
}
