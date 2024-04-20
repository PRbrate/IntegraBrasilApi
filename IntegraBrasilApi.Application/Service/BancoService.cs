using AutoMapper;
using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Service.Intefaces;
using IntegraBrasilApi.Mappings;

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
            var bancoDto = banco.DataReturn.ConverterBancoParaDto();
            var response = new ResponseGeneric<BancoDto>() 
            { 
                StatusCode = banco.StatusCode,
                DataReturn = bancoDto,
                ErroRetorno = banco.ErroRetorno
            };
            return response;
        }

    }
}
