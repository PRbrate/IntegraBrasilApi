using AutoMapper;
using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Service.Intefaces;

namespace IntegraBrasilApi.Service
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public EnderecoService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGeneric<EnderecoDto>> GetEnderecoDto(string cep)
        {
            var endereco  = await _brasilApi.GetEndereco(cep);

            return _mapper.Map<ResponseGeneric<EnderecoDto>>(endereco);  
        }
    }
}
