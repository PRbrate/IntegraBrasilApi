using AutoMapper;
using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Entities;
using IntegraBrasilApi.Service.Intefaces;

namespace IntegraBrasilApi.Service
{
    public class BancoService : IBancoService
    {

        private readonly IBrasilApi _brasilApi;
        private readonly IMapper _mapper;

        public BancoService(IBrasilApi brasilApi, IMapper mapper)
        {
            _brasilApi = brasilApi;
            _mapper = mapper;
        }

        public async Task<ResponseGeneric<List<BancoDto>>> GetBancos()
        {
            var bancos = await _brasilApi.GetBancos();
            return _mapper.Map<ResponseGeneric<List<BancoDto>>>(bancos);

        }
        public async Task<ResponseGeneric<BancoDto>> GetBancoId(string codigoBanco)
        {
            var banco = await _brasilApi.GetBancoId(codigoBanco);
            return _mapper.Map<ResponseGeneric<BancoDto>>(banco);
        }

    }
}
