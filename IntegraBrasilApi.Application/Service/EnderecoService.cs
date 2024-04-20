using AutoMapper;
using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Service.Intefaces;
using IntegraBrasilApi.Mappings;

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
            var endereco = await _brasilApi.GetEndereco(cep);
            var enderecoDto = endereco.DataReturn.ConverterEnderecoParaDto();

            var response = new ResponseGeneric<EnderecoDto>() 
            { 
                StatusCode = endereco.StatusCode,
                DataReturn = enderecoDto,
                ErroRetorno = endereco.ErroRetorno
            };
            return response;

        }
    }
}
