using IntegraBrasilApi.DTOs;

namespace IntegraBrasilApi.Web.Fluent.Services.Interface
{
    public interface IBancoService
    {
        Task<BancoDto> banco(string banco);

    }
}
