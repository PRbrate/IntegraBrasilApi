using AutoMapper;
using IntegraBrasilApi.Application.DTOs;
using IntegraBrasilApi.Application.Service.Intefaces;
using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Service.Intefaces;

namespace IntegraBrasilApi.Application.Service
{
    public class CnpjService : ICnpjService
    {
        private readonly IBrasilApi _brasilApi;
        private readonly IMapper _mapper;

        public CnpjService(IBrasilApi brasilApi, IMapper mapper)
        {
            _brasilApi = brasilApi;
            _mapper = mapper;
        }

        public async Task<ResponseGeneric<CnpjDto>> GetCnpj(string cnpj)
        {
            var getcnpj = await _brasilApi.GetCnpj(cnpj);
            return _mapper.Map<ResponseGeneric<CnpjDto>>(getcnpj);
        }
    }
}
